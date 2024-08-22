using EShopper.Message.Domain.Entites;

namespace EShopper.Message.Application.Interfaces
{
    public interface IMessageService
    {
        Task<List<UserMessage>> GetUserMessages();
        Task<UserMessage> GetMesssageById(int id);
        Task DeleteMessage(int id);
        Task UpdateMessage(UserMessage message);
        Task CreateMessage(UserMessage message);

    }
}
