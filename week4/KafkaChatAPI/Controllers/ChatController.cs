using Confluent.Kafka;
using KafkaChatAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace KafkaChatAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly string _bootstrapServers = "localhost:9092";
        private readonly string _topic = "chat-messages";

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] ChatMessage message)
        {
            var config = new ProducerConfig { BootstrapServers = _bootstrapServers };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            var jsonMessage = JsonSerializer.Serialize(message);

            var result = await producer.ProduceAsync(_topic, new Message<Null, string> { Value = jsonMessage });

            return Ok(new { status = "Message sent", offset = result.Offset });
        }
    }
}
