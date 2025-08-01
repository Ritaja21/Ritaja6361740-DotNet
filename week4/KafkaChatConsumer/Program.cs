﻿using Confluent.Kafka;

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = "chat-consumer-group",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
consumer.Subscribe("chat-messages");

Console.WriteLine("🔁 Listening for chat messages...");

try
{
    while (true)
    {
        var cr = consumer.Consume();
        Console.WriteLine($"📨 Message: {cr.Message.Value}");
    }
}
catch (OperationCanceledException)
{
    consumer.Close();
}
