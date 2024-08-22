using EShopper.Message.Application.Interfaces;
using EShopper.Message.Domain.Entites;
using EShopper.Message.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace EShopper.Message.Persistence.Concrete
{
    public class MessageService : IMessageService
    {
        private readonly MessageContext _context;

        public MessageService(MessageContext context)
        {
            _context = context;
        }

        public async Task CreateMessage(UserMessage message)
        {
            await _context.AddAsync(message);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMessage(int id)
        {
            var value = await _context.userMessages.FindAsync(id);
            _context.userMessages.Remove(value);
            await _context.SaveChangesAsync();
        }

        public async Task<UserMessage> GetMesssageById(int id)
        {
            var value = await _context.userMessages.FindAsync(id);
            return value;

        }

        public async Task<List<UserMessage>> GetUserMessages()
        {
            return await _context.userMessages.ToListAsync();
        }

        public async Task UpdateMessage(UserMessage message)
        {
            var value = await _context.userMessages.FindAsync(message.UserMessageId);
            _context.userMessages.Update(value);
            await _context.SaveChangesAsync();
        }
    }
}
