﻿using Microsoft.AspNetCore.SignalR;
namespace ConfidentialTrading;

public class SensorDataHub : Hub
{
    // Since this is only used for sending from server to client, we don't have to define
    // any client-callable methods here.
}
