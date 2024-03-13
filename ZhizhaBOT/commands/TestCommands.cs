using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace ZhizhaBOT.commands
{
    public  class TestCommands : BaseCommandModule
    {
        [Command("test")]
        public async Task MyFirstCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"Rusik {ctx.User.Username}") ;
        }

        [Command("add")]
        public async Task AddNumbers(CommandContext ctx,int num1,int num2)
        {
            await ctx.Channel.SendMessageAsync((num1+num2).ToString());
        }
    }
}
