using Exolix.Api;	
try
{
	var config = new ExolixConfig();
	config.AuthorizationToken = "Bearer eyJhbGciOiJ.......";

    IExolixClient client = new ExolixClient(config);
	var list = client.GetAvailableCurrenciesAsync().Result;
	var currecncy = list.Data.FirstOrDefault();
	//var networks = client.GetCurrencyNetworksAsync(currecncy.Code).Result;
	//var net = networks.FirstOrDefault();
	var trans = client.GetTransactionsAsync().Result;
    var tranStatus = client.GetTransactionStatusAsync("ab93061434dd0s").Result;
}
catch (Exception e)
{
	Console.WriteLine(e.ToString());
}