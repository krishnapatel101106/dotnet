# Web Forms AdRotator

Create a classic ASP.NET Web Forms project. Add an XML file named `Ads.xml` to the project:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Advertisements>
  <Ad>
    <ImageUrl>~/Images/ad1.jpg</ImageUrl>
    <NavigateUrl>https://example.com/</NavigateUrl>
    <AlternateText>Visit our website</AlternateText>
    <Impressions>50</Impressions>
    <Keyword>General</Keyword>
  </Ad>
  <Ad>
    <ImageUrl>~/Images/ad2.jpg</ImageUrl>
    <NavigateUrl>https://example.org/</NavigateUrl>
    <AlternateText>Discover more</AlternateText>
    <Impressions>50</Impressions>
    <Keyword>General</Keyword>
  </Ad>
</Advertisements>
```

Create an `Images` folder and add `ad1.jpg` and `ad2.jpg` (or replace filenames with your own images).

In `Default.aspx` inside the server form:
```aspx
<asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Ads.xml" />
```

XML image URLs must point to files that actually exist in the project.
