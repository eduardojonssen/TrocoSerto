using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoSerto.Core.Processor {

	public static class ProcessorFactory {
		public static AbstractProcessor Create(long changeAmount) {
			AbstractProcessor[] processorList = new AbstractProcessor[]{
				new BillProcessor(),
				new CoinProcessor(),
				new SilverProcessor()

				//Adicionar futuros processadores acima desta linha.
			};

			IEnumerable<AbstractProcessor> orderedProcessorList = processorList.OrderByDescending(p => p.GetValues().Min());
			foreach (AbstractProcessor processor in orderedProcessorList) {
				if (changeAmount >= processor.GetValues().Min()) {
					return processor;
				}
			}
			return null;
		}
	}
}
