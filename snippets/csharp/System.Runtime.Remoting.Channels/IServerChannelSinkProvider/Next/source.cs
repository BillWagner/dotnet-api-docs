﻿using System;
using System.Collections;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

public class SinkProviderSampleClass  {
   public static void Main()  {
      // <Snippet1>
      IDictionary prop = new Hashtable();
      prop["port"] = 9000;

      IClientChannelSinkProvider clientChain = new BinaryClientFormatterSinkProvider();

      IServerChannelSinkProvider serverChain = new SoapServerFormatterSinkProvider();
      serverChain.Next = new BinaryServerFormatterSinkProvider();

      ChannelServices.RegisterChannel(new HttpChannel(prop, clientChain, serverChain));
      // </Snippet1>
   }
}
