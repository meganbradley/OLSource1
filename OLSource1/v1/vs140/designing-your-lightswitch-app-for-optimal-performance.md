---
title: "Designing Your LightSwitch App for Optimal Performance"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 480a0b03-935a-473e-b8dc-6d83e2accdac
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Designing Your LightSwitch App for Optimal Performance
Apps have a natural tendency to grow in complexity over time which can cause them to become increasingly slow at both design time and runtime. Designing your app to follow best practices upfront will help you to avoid performance bottlenecks later on as your app evolves.  
  
## Segment Large LightSwitch Apps  
 For apps that have the potential to be complex, you should segment the app so that it is comprised of several smaller LightSwitch apps that all attach to the same data source. In this case, each app corresponds to a “module”. Each module can then selectively choose which entities to connect to which will help keep the complexity of the model to a minimum. For example, you could create a central ASP.Net site that serves as a portal to each of your LightSwitch modules. For further details, refer to the blog posts written by LightSwitch MVP Michael Washington: [Integrating LightSwitch Into an ASPNET App to Provide Single Sign On](http://lightswitchhelpwebsite.com/Blog/tabid/61/EntryId/107/Integrating-LightSwitch-Into-An-ASPNET-Application-To-Provide-Single-Sign-On.aspx) and [An HTML MVC LightSwitch Security Administration](http://lightswitchhelpwebsite.com/Blog/tabid/61/EntryId/3281/An-HTML-MVC-LightSwitch-Security-Administration.aspx).  
  
## Use LightSwitch to Build Small Components of a Broader Solution  
 LightSwitch is designed to work in concert with other applications. In particular, LightSwitch is well-suited for quickly creating simple screens that allow end-users to view, create, edit and delete data that other apps can then utilize. Rather than building a large app using LightSwitch, it is often more appropriate to use LightSwitch to build a specific component that is part of a broader solution.  
  
## Build Large Entity Schemas Outside of LightSwitch  
 If you are creating your schema from scratch and you foresee your app having a large number of entities, we recommend you build your schema in a tool outside of LightSwitch. This will provide you with the most flexibility so that if needed, you can segment your app into smaller modules that all attach to this same external data source.  
  
 If you were instead to create the schema in LightSwitch’s intrinsic data store, all code and screens that interact with this data source will be tightly coupled. This will make it difficult to change your intrinsic data store to become an attached data source if you later need to segment your app to make it more manageable - you will have to manually fix all code and screen references to use the new attached data source.  
  
 Another option is to create a LightSwitch app that is used purely as a service that other LightSwitch apps can consume as an attached, external data source. In this case, you would use LightSwitch as a modeling tool for defining your schema in the intrinsic data store of the service app. Then, apps that attach to this service can selectively choose which entities to consume.  
  
## Reshape Entities  
 Attaching to a data source and selecting only those entities that your app directly uses is the most powerful way to keep the number of entities to a minimum. In addition, you should consider a few options that will allow you to reshape entities for data sources that your app needs to consume. For example, you can reshape entities to:  
  
-   Reduce the number of entities used within your app by combining multiple, separate entities into a single entity.  
  
-   Exclude unneeded properties from entities.  
  
 One option is to create and attach to a custom RIA data source. See [Guidelines for Creating WCF RIA Services for LightSwitch](../vs140/guidelines-for-creating-wcf-ria-services-for-lightswitch.md). By implementing a custom RIA data source, you can define entities in the shape that your app needs and use these entities like you would any other LightSwitch entity, such as binding these entities to screens. Another option is to create your own custom View within your attached data source. LightSwitch will then allow you to attach to this View like any other entity. See [Attaching to SQL Views](http://blogs.msdn.com/b/lightswitch/archive/2014/05/20/attaching-to-sql-views.aspx).  
  
 When reshaping entities, a careful balance must be maintained so that your schema doesn’t have an excessive number of entities and so that individual entities don’t have an excessive number of properties. As result, it’s important to think about the scenario in which the entity will be used. Suppose you have an entity with a large number of properties. When this entity is bound to a screen with a grid, even if you are only showing a subset of the properties on the screen itself, all of the entity’s property data is still requested. In this situation, it may make more sense to use a composition pattern where you split the entity into two entities that share a 0..1 relationship. Or, you may choose to create a RIA data source to avoid including all of the entity’s properties since you only need to display a small subset.  For further details on this along with additional tips on performance, see [LightSwitch – 10 Performance Tweaks Anyone Can Do](http://blogs.msdn.com/b/rmattsampson/archive/2012/12/28/lightswitch-performance-tweaks-anyone-can-do.aspx).  
  
## Simplify Screen Design  
 The complexity of a screen’s .lsml model file grows with the number of screen properties, controls and queries, so it’s important to keep screens simple:  
  
1.  **Avoid excessive use of modal windows**  
  
     Modal windows are modeled as part of their parent screen and as a result, they are stored within the same .lsml model file. If you have a lot of modal windows defined as part of a single screen, this will potentially cause your .lsml model file to become large which can cause performance issues. Based on this, we recommend that you avoid designing your app to use a large number of modal windows.  
  
2.  **Avoid unnecessary layers of group controls**  
  
     Structure the layout of your screen to ensure that it doesn’t have unnecessary layers of group controls that have no impact on the end-user’s experience. There also may be cases where you are tempted to use extra group controls in order to get the desired padding and alignment. If this becomes frequent, you should instead consider creating your own custom control which will provide you with greater flexibility in controlling the layout. See [How to: Create a LightSwitch Control](assetId:///4834b46b-3093-4027-9686-93d66cc2e2b3) or [How to: Add a Custom Control to an HTML Screen for a LightSwitch App](../vs140/how-to--add-a-custom-control-to-an-html-screen-for-a-lightswitch-app.md).  
  
3.  **Use separate screens instead of tab controls**  
  
     Having a large number of tabs on your screen not only makes the screen’s .lsml model file larger, it also incurs a runtime cost. Rather than designing your screens so that they contain a lot of tabs, you should instead consider separating each tab into its own screen.  
  
4.  **Limit use of screen queries**  
  
     Having a large number of queries (e.g. screen collection properties) on your screen impacts the design time experience since it introduces complexity. We’ve found that as the number of screen queries and properties grows, the slower screen design time performance becomes. Furthermore, if these queries are executed when the screen is first opened, this will cause a runtime bottleneck.  
  
5.  **Use other screen technologies**  
  
     You also have the option of creating your own screens. Specifically, you may choose to use the Server App Context to interact with your app’s entities on the middle tier (e.g. server) outside the context of the LightSwitch client. The benefit here is that you can use other technologies to build your own screens, such as simplified web interface, without having the overhead of LightSwitch screens. See [Using the LightSwitch ServerApplicationContext API](http://blogs.msdn.com/b/lightswitch/archive/2013/04/15/using-serverapplicationcontext.aspx).  
  
## Optimize Queries, Computations, and Validation  
 Incorrect use of queries, computed properties, and property validation can have a negative impact on performance. Furthermore, there are tactics you can use to improve performance of large computations. Refer to the following tips:  
  
1.  **Minimize code within PreProcessQuery method**  
  
     The `PreprocessQuery` method, an override that is available on a modeled query, allows you to modify the query through code before it is executed. For example, you may modify the query by adding a filter or sort. Although the `PreprocessQuery` method provides a lot of flexibility, it’s important to remember that any code that you add to this method may potentially impact the query’s performance. For this reason, you should avoid adding intensive business logic or spawning queries from within this method.  
  
2.  **Manage screens static spans**  
  
     Each screen provides the ability to manage static spans which allows you to tell LightSwitch which related entities should be eager-loaded when a screen is launched. You typically only need to manage static spans when you have written custom screen code that queries for related entities or when using custom controls. Otherwise, for entities that are bound directly to a screen, LightSwitch will automatically manage static spans for you. For example, suppose you have a ‘Customer’ entity that has a related ‘Address’ entity with a ‘City’ property. When you display the ‘Customer.Address.City’ property on a grid, LightSwitch automatically retrieves the ‘Customer’ and the related ‘Address’ entity in one service call. If instead you have custom screen code that queries for the related ‘Address’ entity (and ‘Address’ isn’t bound to the screen), LightSwitch will make separate service calls each time that your code queries for ‘Address’.  To solve this, you need to manage static spans on your own. For further details on how to manage static spans along with other tips on how to optimize queries, see [LightSwitch Tips & Tricks on Query Performance](http://blogs.msdn.com/b/bethmassi/archive/2012/05/29/lightswitch-tips-amp-tricks-on-query-performance.aspx).  
  
3.  **Perform validation on the server**  
  
     Having too much validation logic at the entity’s property level can cause runtime performance issues. Instead, if your app needs to perform a large amount of validation, you should define this logic within the server’s save pipeline. The end-user experience will be slightly different since the user isn’t presented with a validation error until they’ve saved, but this trade-off is often worth the performance gain. See [How to: Validate Data in a LightSwitch Application](../vs140/how-to--validate-data-in-a-lightswitch-application.md) or [Getting the Most Out of the Save Pipeline in Visual Studio LightSwitch](http://www.codemag.com/Article/1103071).  
  
4.  **Perform calculations on the server**  
  
     Having a large number of computed properties can negatively impact runtime performance. This becomes problematic when:  
  
    -   There are large number of computed properties displayed on screen; for example, a computed property that exists on a grid so that calculations are computed for each individual record.  
  
    -   The computed property’s calculation performs one or more queries.  
  
    -   The computed property is used within shared validation logic, defined at either the entity’s property level or the save pipeline.  
  
         Rather than use computed properties, you should instead perform the calculations on the server using a custom RIA data source.  Or, you may choose to persist the calculated fields within your database which will enable you to be able to filter on these fields (since filtering on computed properties isn’t supported). See [Guidelines for Creating WCF RIA Services for LightSwitch](../vs140/guidelines-for-creating-wcf-ria-services-for-lightswitch.md).  
  
5.  **Perform large computations using command-table pattern**  
  
     The command-table pattern allows you to call an operation that runs on the server. An operation is particularly useful to create, update, and delete a large number of entities since performance will be better when this code is run on the server.  Suppose your app allows the user to request a new holiday for 30 consecutive days. Rather than creating 30 ‘Holiday’ entities on the client, you would instead create a ‘HolidayRequest’ entity that is simply used to execute a command that creates the 30 ‘Holiday’ entity instances on the server. When you save, LightSwitch will automatically send any server-side changes back to the client so that data is refreshed accordingly. See [Being serious about the command table pattern](http://blog.pragmaswitch.com/?p=332).  
  
6.  **Save often when performing large computations**  
  
     If you cannot use the command-table pattern to perform large computations, make sure that you save often so that the contents of a change set don’t become overly large. Change sets that contain a large number of “dirty” entities are generally much slower to process than smaller sized change sets. For example, you’ll notice a difference in performance if you save 2000 new entities that are all in the same change set versus saving 50 separate change sets that each contain 40 new entities.  
  
## Optimizing a LightSwitch App's Performance  
 If you have an existing LightSwitch app that is beginning to grow in complexity and you are experiencing design time and runtime performance bottlenecks, there are various tactics that you can try to improve performance. These tips are also useful even if you’re just starting to design and build your app from scratch.  
  
1.  **Use Visual Studio 2013 or later**  
  
     Starting in Visual Studio 2013, LightSwitch was updated to persist model elements as smaller, more manageable chunks so that each entity, query, and screen is now contained within its own .lsml model file. This has helped to keep .lsml model files a reasonable size which is important since the larger these files become, the longer it takes LightSwitch to load and parse them. Another reason to upgrade is that in Visual Studio 2012 Update 2, LightSwitch was switched to use a JSON light as the payload format for communicating between the client and server. To gain both of these benefits, we recommend that you use Visual Studio 2013 or later. For existing LightSwitch apps, this means that you will need to upgrade them to this version. See [LightSwitch Performance Win in Visual Studio 2013](http://blogs.msdn.com/b/visualstudio/archive/2013/10/09/lightswitch-performance-win-in-visual-studio-2013.aspx).  
  
2.  **Optimize Visual Studio state**  
  
     Use Visual Studio in your favor by leaving your app in a desirable state before you close it; specifically, the amount of time that it takes to re-open your app can be improved if the screen designer’s tabs are closed before closing the solution. Furthermore, if the screen designer is slow, try the following to help speed up the designer:  
  
    -   Collapse screen designer items that you aren’t working on.  
  
    -   Minimize the number of screen designers you have open concurrently.  
  
3.  **Clean up your app’s model**  
  
     Any unused model elements should be removed since even a few extra elements can impact performance. This applies to unused entities, entity properties, queries, screens, and screen controls/properties. Here are a few common ways where you can potentially remove unused elements and in general, clean up your app:  
  
    -   **Clean up summary controls**  
  
         **Summary** controls may potentially contain extra properties if at any point you have toggled the control type to be a **Table Layout**, **Rows Layout**, or **Columns Layout** group control.  
  
    -   **Remove created/modified properties**  
  
         By default, each entity automatically has created/modified properties added even though they are not explicitly modeled on the entity itself. If you do not need to track users that create/modify entities, then you should disable these properties so that they aren’t automatically added. See [Automatic Row Tracking with Visual Studio 2013](http://blogs.msdn.com/b/lightswitch/archive/2013/11/12/automatic-row-tracking-with-visual-studio-2013-amr-altahlawi.aspx).  
  
    -   **Fix compile warnings**  
  
         Some compile warnings indicate a larger issue that causes performance problems, so it’s important to resolve them. One compile warning that is known to cause a performance issue is if you have attached to a data source and then changed the type in the entity designer so that there is a loss of precision – for example, from `DateTime` to `Date`.  
  
4.  **Use 3-tier deployment**  
  
     If you are using 2-tier deployment and it’s feasible, you may consider moving to 3-tier deployment.  Although a 3-tier approach introduces a web server, this configuration provides better scalability.  This setup is appropriate if you have many users or you need to support web browser-based clients over the internet.  In this case IIS handles requests instead of connecting to the database directly.  This also provides an easier setup and upgrade distribution model. See [How to: Deploy a Three-Tier LightSwitch Application](../vs140/how-to--deploy-a-three-tier-lightswitch-application.md).  
  
5.  **Include necessary data only**  
  
     A general rule of thumb is to make sure your app is only sending the appropriate amount of data to the client – you only want to retrieve data that is actually being used and/or displayed. If you notice your screen runtime performance is slow, use a tool like [Fiddler](http://www.telerik.com/fiddler) to monitor requests and returned data. Refer to the sections mentioned previously in this document on how to reshape entities and how to manage static spans to help alleviate issues with too much data being sent to the client.  
  
6.  **Remove third-party extensions**  
  
     On occasion, third party extensions have introduced performance bottlenecks. If you’re experiencing a bottleneck, we recommend that you disable all of these extensions to rule out that they aren’t the cause.  
  
7.  **Disable anti-virus/anti-malware apps**  
  
     Disabling your anti-virus and anti-malware app has been known to provide some help with design time performance issues. Since virus scanning apps typically observe reads and writes for file input/output calls, this adds extra time to calls made by Visual Studio’s devenv.exe app. Make sure that you take extra care to only disable these for Visual Studio’s devenv.exe app.  
  
8.  **Investigate app restructuring**  
  
     If none of the above options help, then the underlying issue may be that your app has surpassed the complexity that LightSwitch is intended to support. In this case, you should consider restructuring your app following the best practices that are already mentioned above, such as segmenting your app.  
  
## See Also  
 [Visual Studio LightSwitch](../vs140/visual-studio-lightswitch.md)