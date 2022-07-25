using ChatApp.Dtos;
using ChatApp.Entity;

namespace ChatApp.Extention
{
    public  static class ToDto
    {
        public static MessageITem ChatToDto(this ChatEntity entity)
        {
            return new MessageITem(entity.id, entity.Name, entity.Message);
        }
    }
}
 