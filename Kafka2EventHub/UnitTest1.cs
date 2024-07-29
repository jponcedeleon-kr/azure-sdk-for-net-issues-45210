using Azure.Core.Amqp;
using Azure.Messaging.EventHubs;

namespace Kafka2EventHub;

public class UnitTest1
{
    [Fact]
    public void ShouldConvertHeadersFromKafkaToEventHub()
    {
        var eventData = new EventData("test_message")
        {
            Properties =
            {
                ["test_header"] = "test_value"u8.ToArray()
            }
        };

        var result = eventData.GetRawAmqpMessage().ToBytes();
        
        Assert.NotNull(result);
    }
}