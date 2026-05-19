namespace RSSFeedReader.API.Controllers;

using Microsoft.AspNetCore.Mvc;
using RSSFeedReader.API.DTOs;
using RSSFeedReader.API.Services;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly ISubscriptionService _subscriptionService;

    public SubscriptionsController(ISubscriptionService subscriptionService)
    {
        _subscriptionService = subscriptionService;
    }

    /// <summary>
    /// Add a new subscription
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<SubscriptionResponse>> AddSubscription(CreateSubscriptionRequest request)
    {
        var subscription = await _subscriptionService.AddSubscriptionAsync(request.Url);
        var response = new SubscriptionResponse
        {
            Id = subscription.Id,
            Url = subscription.Url
        };
        return CreatedAtAction(nameof(GetSubscriptions), new { id = subscription.Id }, response);
    }

    /// <summary>
    /// Get all subscriptions
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<SubscriptionResponse>>> GetSubscriptions()
    {
        var subscriptions = await _subscriptionService.GetAllSubscriptionsAsync();
        var responses = subscriptions.Select(s => new SubscriptionResponse
        {
            Id = s.Id,
            Url = s.Url
        });
        return Ok(responses);
    }
}
