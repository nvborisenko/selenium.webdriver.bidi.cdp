namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class DomTests : CdpTestFixture
{
    [Test]
    public async Task GetDocumentAndQuerySelector()
    {
        await Cdp.Page.NavigateAsync("data:text/html,<html><body><div id='content'><p class='message'>Hello CDP</p></div></body></html>");

        var document = await Cdp.DOM.GetDocumentAsync();

        await Assert.That(document.Root).IsNotNull();
        await Assert.That(document.Root.NodeName).IsEqualTo("#document");

        // Query for the paragraph
        var pNode = await Cdp.DOM.QuerySelectorAsync(document.Root.NodeId, "p.message");

        await Assert.That(pNode.NodeId).IsNotNull();

        var outerHtml = await Cdp.DOM.GetOuterHTMLAsync(nodeId: pNode.NodeId);

        await Assert.That(outerHtml.OuterHTML).IsEqualTo("<p class=\"message\">Hello CDP</p>");
    }

    [Test]
    public async Task QuerySelectorAll()
    {
        await Cdp.Page.NavigateAsync("data:text/html,<html><body><ul><li>One</li><li>Two</li><li>Three</li></ul></body></html>");

        var document = await Cdp.DOM.GetDocumentAsync();

        var result = await Cdp.DOM.QuerySelectorAllAsync(document.Root.NodeId, "li");

        await Assert.That(result.NodeIds.Count).IsEqualTo(3);
    }

    [Test]
    public async Task SetAttributeValue()
    {
        await Cdp.Page.NavigateAsync("data:text/html,<html><body><div id='target'>Content</div></body></html>");

        var document = await Cdp.DOM.GetDocumentAsync();
        var div = await Cdp.DOM.QuerySelectorAsync(document.Root.NodeId, "#target");

        await Cdp.DOM.SetAttributeValueAsync(div.NodeId, "data-custom", "test-value");

        var outerHtml = await Cdp.DOM.GetOuterHTMLAsync(nodeId: div.NodeId);

        await Assert.That(outerHtml.OuterHTML).Contains("data-custom=\"test-value\"");
    }

    [Test]
    public async Task GetBoxModel()
    {
        await Cdp.Page.NavigateAsync("data:text/html,<html><body><div id='box' style='width:200px;height:100px;margin:10px;padding:5px;'>Box</div></body></html>");

        var document = await Cdp.DOM.GetDocumentAsync();
        var div = await Cdp.DOM.QuerySelectorAsync(document.Root.NodeId, "#box");

        var boxModel = await Cdp.DOM.GetBoxModelAsync(nodeId: div.NodeId);

        await Assert.That(boxModel.Model).IsNotNull();
        await Assert.That(boxModel.Model.Width).IsGreaterThan(0);
        await Assert.That(boxModel.Model.Height).IsGreaterThan(0);
    }

    [Test]
    public async Task GetDocumentWithDepth()
    {
        await Cdp.Page.NavigateAsync("data:text/html,<html><body><div><span><a href='#'>Link</a></span></div></body></html>");

        var document = await Cdp.DOM.GetDocumentAsync(depth: -1, pierce: true);

        await Assert.That(document.Root).IsNotNull();
        await Assert.That(document.Root.Children).IsNotNull();
        await Assert.That(document.Root.Children!.Value).IsNotEmpty();
    }
}
