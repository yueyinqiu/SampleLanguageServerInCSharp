using EmmyLua.LanguageServer.Framework.Protocol.Capabilities.Client.ClientCapabilities;
using EmmyLua.LanguageServer.Framework.Protocol.Capabilities.Server;
using EmmyLua.LanguageServer.Framework.Protocol.Capabilities.Server.Options;
using EmmyLua.LanguageServer.Framework.Protocol.Message.Completion;
using EmmyLua.LanguageServer.Framework.Protocol.Model.Kind;
using EmmyLua.LanguageServer.Framework.Server.Handler;

namespace Server;
public sealed class MyHandler : CompletionHandlerBase
{
    public override void RegisterCapability(ServerCapabilities serverCapabilities, ClientCapabilities clientCapabilities)
    {
        serverCapabilities.CompletionProvider = new CompletionOptions();
    }

    protected override Task<CompletionResponse?> Handle(CompletionParams request, CancellationToken token)
    {
        return Task.FromResult(new CompletionResponse([
            new()
            {
                Label = "SnippetOne",
                InsertText = "WOW!",
                Kind = CompletionItemKind.Text,
                InsertTextFormat = InsertTextFormat.Snippet,
                SortText = "1"
            },
            new()
            {
                Label = "SnippetTwo",
                InsertText = "YES!",
                Kind = CompletionItemKind.Text,
                InsertTextFormat = InsertTextFormat.Snippet,
                SortText = "2"
            }
        ]))!;
    }

    protected override Task<CompletionItem> Resolve(CompletionItem item, CancellationToken token)
    {
        return Task.FromResult(item)!;
    }
}
