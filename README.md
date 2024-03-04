Reverse engineer AliExpress product display API to quickly scrape data without needing authentication, html scraping, just request json.

There is seemingly no expiry on the API token string, however you need to fetch it initially once using PlayWright.

However, there is some drawbacks:
 
1. AliExpress 'new user coupon' prices. You can't get rid of this.

2. Variation listing pricing.

To overcome these issues, there is also two other scraping methods:

1. PlayWright browser simulation (slow and not fully reliable)

2. HttpClient to request page html and scraping the json from it. (Allows variation pricing but not new user bypass).
