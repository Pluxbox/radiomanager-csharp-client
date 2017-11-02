# RadioManager - the C# library for the RadioManager

Pluxbox RadioManager gives you the power, flexibility and speed you always wanted in a lightweight and easy-to-use web-based radio solution. With Pluxbox RadioManager you can organise your radio workflow and automate your omnichannel communication with your listeners. We offer wide range specialised services for the radio and connections like Hybrid Radio, Visual Radio, your website and social media without losing focus on your broadcast. For more information visit: pluxbox.com

- API version: 2.0
- SDK version: 1.1.2
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://pluxbox.com](https://pluxbox.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out RadioManager.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using RadioManager.Api;
using RadioManager.Client;
using RadioManager.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: API Key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new BlockApi();
            var id = 789;  // long? | ID of Block **(Required)**
            var externalStationId = 789;  // long? | Query on a different (content providing) station *(Optional)* (optional) 

            try
            {
                // Get block by id
                BlockResult result = apiInstance.GetBlockById(id, externalStationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.GetBlockById: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://radiomanager.io/api/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BlockApi* | [**GetBlockById**](docs/BlockApi.md#getblockbyid) | **GET** /blocks/{id} | Get block by id
*BlockApi* | [**GetCurrentBlock**](docs/BlockApi.md#getcurrentblock) | **GET** /blocks/current | Get current Block
*BlockApi* | [**GetNextBlock**](docs/BlockApi.md#getnextblock) | **GET** /blocks/next | Get next Block
*BlockApi* | [**ListBlocks**](docs/BlockApi.md#listblocks) | **GET** /blocks | Get a list of all blocks currently in your station.
*BroadcastApi* | [**CreateBroadcast**](docs/BroadcastApi.md#createbroadcast) | **POST** /broadcasts | Create broadcast.
*BroadcastApi* | [**DeleteBroadcastById**](docs/BroadcastApi.md#deletebroadcastbyid) | **DELETE** /broadcasts/{id} | Delete broadcast by id
*BroadcastApi* | [**GetBroadcastById**](docs/BroadcastApi.md#getbroadcastbyid) | **GET** /broadcasts/{id} | Get broadcast by id
*BroadcastApi* | [**GetCurrentBroadcast**](docs/BroadcastApi.md#getcurrentbroadcast) | **GET** /broadcasts/current | Get current Broadcast
*BroadcastApi* | [**GetDailyEPG**](docs/BroadcastApi.md#getdailyepg) | **GET** /broadcasts/epg/daily | Get daily EPG
*BroadcastApi* | [**GetEPGByDate**](docs/BroadcastApi.md#getepgbydate) | **GET** /broadcasts/epg | Get EPG by date
*BroadcastApi* | [**GetNextBroadcast**](docs/BroadcastApi.md#getnextbroadcast) | **GET** /broadcasts/next | Get next Broadcast
*BroadcastApi* | [**GetWeeklyEPG**](docs/BroadcastApi.md#getweeklyepg) | **GET** /broadcasts/epg/weekly | Get weekly EPG
*BroadcastApi* | [**ListBroadcasts**](docs/BroadcastApi.md#listbroadcasts) | **GET** /broadcasts | Get all broadcasts.
*BroadcastApi* | [**PrintBroadcastById**](docs/BroadcastApi.md#printbroadcastbyid) | **GET** /broadcasts/print/{id} | Print Broadcast by id
*BroadcastApi* | [**UpdateBroadcastByID**](docs/BroadcastApi.md#updatebroadcastbyid) | **PATCH** /broadcasts/{id} | Update broadcast by id
*CampaignApi* | [**CreateCampaign**](docs/CampaignApi.md#createcampaign) | **POST** /campaigns | Create campaign.
*CampaignApi* | [**DeleteCampaignById**](docs/CampaignApi.md#deletecampaignbyid) | **DELETE** /campaigns/{id} | Delete campaign by id
*CampaignApi* | [**GetCampaignById**](docs/CampaignApi.md#getcampaignbyid) | **GET** /campaigns/{id} | Get campaign by id
*CampaignApi* | [**ListCampaigns**](docs/CampaignApi.md#listcampaigns) | **GET** /campaigns | Get all campaigns.
*CampaignApi* | [**UpdateCampaignByID**](docs/CampaignApi.md#updatecampaignbyid) | **PATCH** /campaigns/{id} | Update campaign by id
*ContactApi* | [**CreateContact**](docs/ContactApi.md#createcontact) | **POST** /contacts | Create contact.
*ContactApi* | [**DeleteContactById**](docs/ContactApi.md#deletecontactbyid) | **DELETE** /contacts/{id} | Delete contact by id
*ContactApi* | [**GetContactById**](docs/ContactApi.md#getcontactbyid) | **GET** /contacts/{id} | Get contact by id
*ContactApi* | [**ListContacts**](docs/ContactApi.md#listcontacts) | **GET** /contacts | Get all contacts.
*ContactApi* | [**UpdateContactByID**](docs/ContactApi.md#updatecontactbyid) | **PATCH** /contacts/{id} | Update contact by id
*GenreApi* | [**GetGenreById**](docs/GenreApi.md#getgenrebyid) | **GET** /genres/{id} | Get genre by id
*GenreApi* | [**ListGenres**](docs/GenreApi.md#listgenres) | **GET** /genres | List all genres.
*ItemApi* | [**CreateItem**](docs/ItemApi.md#createitem) | **POST** /items | Create an new item.
*ItemApi* | [**CurrentItemPostStructure**](docs/ItemApi.md#currentitempoststructure) | **POST** /items/current/structure | Post a current playing item, keep structure
*ItemApi* | [**CurrentItemPostTiming**](docs/ItemApi.md#currentitemposttiming) | **POST** /items/current/timing | Post a current playing item
*ItemApi* | [**DeleteItemById**](docs/ItemApi.md#deleteitembyid) | **DELETE** /items/{id} | Delete item by ID.
*ItemApi* | [**GetItemById**](docs/ItemApi.md#getitembyid) | **GET** /items/{id} | Get extended item details by ID.
*ItemApi* | [**ListItems**](docs/ItemApi.md#listitems) | **GET** /items | Get a list of all the items currently in your station.
*ItemApi* | [**PlaylistPostStructure**](docs/ItemApi.md#playlistpoststructure) | **POST** /items/playlist/structure | Post a playlist, keep current structure
*ItemApi* | [**PlaylistPostTiming**](docs/ItemApi.md#playlistposttiming) | **POST** /items/playlist/timing | Post a playlist
*ItemApi* | [**UpdateItemById**](docs/ItemApi.md#updateitembyid) | **PATCH** /items/{id} | Update extended item details by ID.
*ModelTypeApi* | [**GetModelTypeById**](docs/ModelTypeApi.md#getmodeltypebyid) | **GET** /model_types/{id} | Get modelType by id
*ModelTypeApi* | [**ListModelTypes**](docs/ModelTypeApi.md#listmodeltypes) | **GET** /model_types | Get all modelTypes.
*PresenterApi* | [**CreatePresenter**](docs/PresenterApi.md#createpresenter) | **POST** /presenters | Create presenter.
*PresenterApi* | [**DeletePresenterById**](docs/PresenterApi.md#deletepresenterbyid) | **DELETE** /presenters/{id} | Delete presenter by id
*PresenterApi* | [**GetPresenterById**](docs/PresenterApi.md#getpresenterbyid) | **GET** /presenters/{id} | Get presenter by id
*PresenterApi* | [**ListPresenters**](docs/PresenterApi.md#listpresenters) | **GET** /presenters | Get all presenters.
*PresenterApi* | [**UpdatePresenterByID**](docs/PresenterApi.md#updatepresenterbyid) | **PATCH** /presenters/{id} | Update presenter by id
*ProgramApi* | [**CreateProgram**](docs/ProgramApi.md#createprogram) | **POST** /programs | Create program.
*ProgramApi* | [**DeleteProgramById**](docs/ProgramApi.md#deleteprogrambyid) | **DELETE** /programs/{id} | Delete program by id
*ProgramApi* | [**GetProgramById**](docs/ProgramApi.md#getprogrambyid) | **GET** /programs/{id} | Get program by id
*ProgramApi* | [**ListPrograms**](docs/ProgramApi.md#listprograms) | **GET** /programs | Get all programs.
*ProgramApi* | [**UpdateProgramByID**](docs/ProgramApi.md#updateprogrambyid) | **PATCH** /programs/{id} | Update program by id
*StationApi* | [**GetStation**](docs/StationApi.md#getstation) | **GET** /station | Get own station only
*StoryApi* | [**CreateStory**](docs/StoryApi.md#createstory) | **POST** /stories | Create story.
*StoryApi* | [**DeleteStoryById**](docs/StoryApi.md#deletestorybyid) | **DELETE** /stories/{id} | Delete story by id
*StoryApi* | [**GetStoryById**](docs/StoryApi.md#getstorybyid) | **GET** /stories/{id} | Get story by id
*StoryApi* | [**ListStories**](docs/StoryApi.md#liststories) | **GET** /stories | Get all stories.
*StoryApi* | [**UpdateStoryByID**](docs/StoryApi.md#updatestorybyid) | **PATCH** /stories/{id} | Update story by id
*StringApi* | [**GetStringsByName**](docs/StringApi.md#getstringsbyname) | **GET** /strings/{name} | Get Strings (formatted)
*TagApi* | [**CreateTag**](docs/TagApi.md#createtag) | **POST** /tags | Create tag.
*TagApi* | [**DeleteTagById**](docs/TagApi.md#deletetagbyid) | **DELETE** /tags/{id} | Delete tag by id
*TagApi* | [**GetTagById**](docs/TagApi.md#gettagbyid) | **GET** /tags/{id} | Get tags by id
*TagApi* | [**ListTags**](docs/TagApi.md#listtags) | **GET** /tags | Get a list of all the tags currently in your station.
*TagApi* | [**UpdateTagByID**](docs/TagApi.md#updatetagbyid) | **PATCH** /tags/{id} | Update tag by id
*UserApi* | [**DeleteUserById**](docs/UserApi.md#deleteuserbyid) | **DELETE** /users/{id} | Remove user from station by Id
*UserApi* | [**GetUserById**](docs/UserApi.md#getuserbyid) | **GET** /users/{id} | Get user by id
*UserApi* | [**InviteUserByMail**](docs/UserApi.md#inviteuserbymail) | **POST** /users/invite | Invite user by mail
*UserApi* | [**ListUsers**](docs/UserApi.md#listusers) | **GET** /users | Get all users.
*VisualSlideApi* | [**GetVisualSlide**](docs/VisualSlideApi.md#getvisualslide) | **GET** /visual | Get Visual Slide Image as Base64


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Block](docs/Block.md)
 - [Model.BlockRelations](docs/BlockRelations.md)
 - [Model.BlockRelationsBroadcast](docs/BlockRelationsBroadcast.md)
 - [Model.BlockRelationsBroadcastParams](docs/BlockRelationsBroadcastParams.md)
 - [Model.BlockRelationsItems](docs/BlockRelationsItems.md)
 - [Model.BlockRelationsItemsParams](docs/BlockRelationsItemsParams.md)
 - [Model.BlockRelationsProgram](docs/BlockRelationsProgram.md)
 - [Model.BlockResults](docs/BlockResults.md)
 - [Model.Broadcast](docs/Broadcast.md)
 - [Model.BroadcastEPGDay](docs/BroadcastEPGDay.md)
 - [Model.BroadcastEPGRelations](docs/BroadcastEPGRelations.md)
 - [Model.BroadcastInputOnly](docs/BroadcastInputOnly.md)
 - [Model.BroadcastOutputOnly](docs/BroadcastOutputOnly.md)
 - [Model.BroadcastRelations](docs/BroadcastRelations.md)
 - [Model.BroadcastRelationsBlocks](docs/BroadcastRelationsBlocks.md)
 - [Model.BroadcastRelationsItems](docs/BroadcastRelationsItems.md)
 - [Model.BroadcastRelationsItemsParams](docs/BroadcastRelationsItemsParams.md)
 - [Model.BroadcastRelationsModelType](docs/BroadcastRelationsModelType.md)
 - [Model.BroadcastRelationsPresenters](docs/BroadcastRelationsPresenters.md)
 - [Model.BroadcastRelationsTags](docs/BroadcastRelationsTags.md)
 - [Model.BroadcastResults](docs/BroadcastResults.md)
 - [Model.Campaign](docs/Campaign.md)
 - [Model.CampaignOutputOnly](docs/CampaignOutputOnly.md)
 - [Model.CampaignRelations](docs/CampaignRelations.md)
 - [Model.CampaignRelationsItems](docs/CampaignRelationsItems.md)
 - [Model.CampaignRelationsItemsParams](docs/CampaignRelationsItemsParams.md)
 - [Model.CampaignResults](docs/CampaignResults.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.ContactOutputOnly](docs/ContactOutputOnly.md)
 - [Model.ContactRelations](docs/ContactRelations.md)
 - [Model.ContactRelationsItems](docs/ContactRelationsItems.md)
 - [Model.ContactRelationsTags](docs/ContactRelationsTags.md)
 - [Model.ContactRelationsTagsParams](docs/ContactRelationsTagsParams.md)
 - [Model.ContactResults](docs/ContactResults.md)
 - [Model.Data](docs/Data.md)
 - [Model.Data1](docs/Data1.md)
 - [Model.EPGResults](docs/EPGResults.md)
 - [Model.Forbidden](docs/Forbidden.md)
 - [Model.Genre](docs/Genre.md)
 - [Model.GenreOutputOnly](docs/GenreOutputOnly.md)
 - [Model.GenreRelations](docs/GenreRelations.md)
 - [Model.GenreRelationsBroadcasts](docs/GenreRelationsBroadcasts.md)
 - [Model.GenreRelationsBroadcastsParams](docs/GenreRelationsBroadcastsParams.md)
 - [Model.GenreRelationsPrograms](docs/GenreRelationsPrograms.md)
 - [Model.GenreResults](docs/GenreResults.md)
 - [Model.ImportItem](docs/ImportItem.md)
 - [Model.InlineResponse202](docs/InlineResponse202.md)
 - [Model.InternalServerError](docs/InternalServerError.md)
 - [Model.InviteUserData](docs/InviteUserData.md)
 - [Model.InviteUserSuccess](docs/InviteUserSuccess.md)
 - [Model.Item](docs/Item.md)
 - [Model.ItemInputOnly](docs/ItemInputOnly.md)
 - [Model.ItemOutputOnly](docs/ItemOutputOnly.md)
 - [Model.ItemRelations](docs/ItemRelations.md)
 - [Model.ItemRelationsBlock](docs/ItemRelationsBlock.md)
 - [Model.ItemRelationsCampaign](docs/ItemRelationsCampaign.md)
 - [Model.ItemRelationsContacts](docs/ItemRelationsContacts.md)
 - [Model.ItemRelationsContactsParams](docs/ItemRelationsContactsParams.md)
 - [Model.ItemRelationsProgram](docs/ItemRelationsProgram.md)
 - [Model.ItemRelationsTags](docs/ItemRelationsTags.md)
 - [Model.ItemResults](docs/ItemResults.md)
 - [Model.ModelReadOnly](docs/ModelReadOnly.md)
 - [Model.ModelType](docs/ModelType.md)
 - [Model.ModelTypeOptions](docs/ModelTypeOptions.md)
 - [Model.ModelTypeOutputOnly](docs/ModelTypeOutputOnly.md)
 - [Model.ModelTypeRelations](docs/ModelTypeRelations.md)
 - [Model.ModelTypeRelationsBroadcasts](docs/ModelTypeRelationsBroadcasts.md)
 - [Model.ModelTypeRelationsCampaigns](docs/ModelTypeRelationsCampaigns.md)
 - [Model.ModelTypeRelationsCampaignsParams](docs/ModelTypeRelationsCampaignsParams.md)
 - [Model.ModelTypeRelationsContacts](docs/ModelTypeRelationsContacts.md)
 - [Model.ModelTypeRelationsItems](docs/ModelTypeRelationsItems.md)
 - [Model.ModelTypeRelationsPresenters](docs/ModelTypeRelationsPresenters.md)
 - [Model.ModelTypeRelationsPrograms](docs/ModelTypeRelationsPrograms.md)
 - [Model.ModelTypeResults](docs/ModelTypeResults.md)
 - [Model.NotFound](docs/NotFound.md)
 - [Model.PostSuccess](docs/PostSuccess.md)
 - [Model.Presenter](docs/Presenter.md)
 - [Model.PresenterOutputOnly](docs/PresenterOutputOnly.md)
 - [Model.PresenterRelations](docs/PresenterRelations.md)
 - [Model.PresenterRelationsBroadcasts](docs/PresenterRelationsBroadcasts.md)
 - [Model.PresenterRelationsPrograms](docs/PresenterRelationsPrograms.md)
 - [Model.PresenterRelationsProgramsParams](docs/PresenterRelationsProgramsParams.md)
 - [Model.PresenterResults](docs/PresenterResults.md)
 - [Model.Program](docs/Program.md)
 - [Model.ProgramInputOnly](docs/ProgramInputOnly.md)
 - [Model.ProgramOutputOnly](docs/ProgramOutputOnly.md)
 - [Model.ProgramRelations](docs/ProgramRelations.md)
 - [Model.ProgramRelationsBlocks](docs/ProgramRelationsBlocks.md)
 - [Model.ProgramRelationsBroadcasts](docs/ProgramRelationsBroadcasts.md)
 - [Model.ProgramRelationsItems](docs/ProgramRelationsItems.md)
 - [Model.ProgramRelationsItemsParams](docs/ProgramRelationsItemsParams.md)
 - [Model.ProgramRelationsPresenters](docs/ProgramRelationsPresenters.md)
 - [Model.ProgramRelationsTags](docs/ProgramRelationsTags.md)
 - [Model.ProgramResults](docs/ProgramResults.md)
 - [Model.RelationsPlaceholder](docs/RelationsPlaceholder.md)
 - [Model.StationResult](docs/StationResult.md)
 - [Model.StationResultStation](docs/StationResultStation.md)
 - [Model.Story](docs/Story.md)
 - [Model.StoryInputOnly](docs/StoryInputOnly.md)
 - [Model.StoryOutputOnly](docs/StoryOutputOnly.md)
 - [Model.StoryRelations](docs/StoryRelations.md)
 - [Model.StoryRelationsItems](docs/StoryRelationsItems.md)
 - [Model.StoryRelationsTags](docs/StoryRelationsTags.md)
 - [Model.StoryRelationsTagsParams](docs/StoryRelationsTagsParams.md)
 - [Model.StoryResults](docs/StoryResults.md)
 - [Model.Success](docs/Success.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.TagOutputOnly](docs/TagOutputOnly.md)
 - [Model.TagRelations](docs/TagRelations.md)
 - [Model.TagRelationsBroadcasts](docs/TagRelationsBroadcasts.md)
 - [Model.TagRelationsBroadcastsParams](docs/TagRelationsBroadcastsParams.md)
 - [Model.TagRelationsContacts](docs/TagRelationsContacts.md)
 - [Model.TagRelationsItems](docs/TagRelationsItems.md)
 - [Model.TagRelationsPrograms](docs/TagRelationsPrograms.md)
 - [Model.TagResults](docs/TagResults.md)
 - [Model.TextString](docs/TextString.md)
 - [Model.TooManyRequests](docs/TooManyRequests.md)
 - [Model.UnprocessableEntity](docs/UnprocessableEntity.md)
 - [Model.UserResult](docs/UserResult.md)
 - [Model.UserResultSettings](docs/UserResultSettings.md)
 - [Model.UserResults](docs/UserResults.md)
 - [Model.VisualResult](docs/VisualResult.md)
 - [Model.BlockResult](docs/BlockResult.md)
 - [Model.BroadcastDataInput](docs/BroadcastDataInput.md)
 - [Model.BroadcastEPGResult](docs/BroadcastEPGResult.md)
 - [Model.BroadcastResult](docs/BroadcastResult.md)
 - [Model.CampaignDataInput](docs/CampaignDataInput.md)
 - [Model.CampaignResult](docs/CampaignResult.md)
 - [Model.ContactDataInput](docs/ContactDataInput.md)
 - [Model.ContactResult](docs/ContactResult.md)
 - [Model.GenreResult](docs/GenreResult.md)
 - [Model.ItemDataInput](docs/ItemDataInput.md)
 - [Model.ItemResult](docs/ItemResult.md)
 - [Model.ModelTypeResult](docs/ModelTypeResult.md)
 - [Model.PresenterDataInput](docs/PresenterDataInput.md)
 - [Model.PresenterEPGResult](docs/PresenterEPGResult.md)
 - [Model.PresenterResult](docs/PresenterResult.md)
 - [Model.ProgramDataInput](docs/ProgramDataInput.md)
 - [Model.ProgramResult](docs/ProgramResult.md)
 - [Model.StoryDataInput](docs/StoryDataInput.md)
 - [Model.StoryResult](docs/StoryResult.md)
 - [Model.TagDataInput](docs/TagDataInput.md)
 - [Model.TagResult](docs/TagResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="API Key"></a>
### API Key

- **Type**: API key
- **API key parameter name**: api-key
- **Location**: HTTP header

