using Sim.Module.Data.Ids;
using Sim.Module.Generic;

namespace Sim.Module.Client
{
	public interface INetworkClientConnection
	{
		PlayerId PlayerId { get; }
		bool IsEstablished { get; }
		void SendToServer(ICommand command);
		void GenerateNetworkLagTargetInterval();
	}
}