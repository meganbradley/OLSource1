---
title: "Creating Web Parts for SharePoint"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "Microsoft.SharePoint.WebControls.DateTimeControl"
  - "Microsoft.SharePoint.WebControls.CssLink"
  - "Microsoft.SharePoint.WebControls.RssLink"
  - "Microsoft.SharePoint.WebControls.Theme"
  - "Microsoft.SharePoint.WebControls.AspMenu"
  - "Microsoft.SharePoint.WebControls.ListProperty"
  - "Microsoft.SharePoint.WebControls.ProjectProperty"
  - "Microsoft.SharePoint.WebControls.FormsDigest"
  - "Microsoft.SharePoint.WebControls.ScriptLink"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, Web Parts"
  - "Web Parts [SharePoint development in Visual Studio], designing"
ms.assetid: a6349e85-45cf-4766-b856-e25c9f1ffd34
caps.latest.revision: 42
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Creating Web Parts for SharePoint
  By using web parts, you can modify the content, appearance, and behavior of pages of a SharePoint site by using a browser. Web parts are server-side controls that run inside a web part page: they're the building blocks of pages that appear on a SharePoint site. See [Building Block: Web Parts](http://go.microsoft.com/fwlink/?LinkID=182097).  
  
 You can create and debug web parts on a SharePoint site by using templates from Visual Studio.  
  
## Creating a Web Part in Visual Studio  
 Create a web part by adding a **Web Part** item to any SharePoint project. You can use a **Web Part** item in a sandboxed solution or a farm solution.  
  
 If you want to design a web part visually by using a designer, create a **Visual Web Part** project or add **Visual Web Part** item to any SharePoint project. You can use a **Visual Web Part** item in a farm solution only.  
  
### Web Part Item  
 A **Web Part** item provides files that you can use to design a web part for a SharePoint site. When you add a **Web Part** item, Visual Studio creates a folder in your project and then adds several files to the folder. The following table describes each file.  
  
|File|Description|  
|----------|-----------------|  
|Elements.xml|Contains information that the Feature definition file in your project uses to deploy the web part.|  
|.webpart file|Provides information that SharePoint needs to display your web part in a web part gallery.|  
|Code File|Contains methods that add controls to the web part and that generate custom content within the web part.|  
  
 For more information, see [How to: Create a SharePoint Web Part](../VS_officedev/how-to--create-a-sharepoint-web-part.md).  
  
### Visual Web Part Item  
 A visual web part is a web part that you create by using the Visual Web Developer designer in Visual Studio. See [Visual Studio Web Development Content Map](assetId:///9c31f93b-c8fb-4599-9b14-6194ec8c7539).  
  
 A visual web part functions the same as any other web part. To add controls, such as buttons and text boxes, to a web part, you add code to an XML file. However, you add controls to a visual web part by dragging or copying them onto the web part from the Visual Studio **Toolbox**. The designer then generates the required code in the XML file. See [How to: Create a SharePoint Web Part by Using a Designer](../VS_officedev/how-to--create-a-sharepoint-web-part-by-using-a-designer.md).  
  
## SharePoint Controls  
 Visual Studio provides some controls for creating SharePoint pages, such as application pages. These controls appear in the **Toolbox** under **SharePoint Controls**. The functionality for these controls derives from the [Microsoft.SharePoint.WebControls](http://go.microsoft.com/fwlink/?LinkId=235315) namespace, which contains ASP.NET server controls that are used on SharePoint site and list pages.  
  
|Control Name|Description|  
|------------------|-----------------|  
|[AspMenu](http://go.microsoft.com/fwlink/?LinkId=235307)|Inserts an ASP menu. For more information, see [Menu Control Overview](http://go.microsoft.com/fwlink/?LinkId=235316).|  
|[CssLink](http://go.microsoft.com/fwlink/?LinkId=235308)|Inserts a **LINK** element into the .aspx page and applies one or more external style sheets defined by **CssRegistration**.|  
|[DateTimeControl](http://go.microsoft.com/fwlink/?LinkId=235306)|Inserts a DateTime control into the .aspx page.|  
|[FormDigest](http://go.microsoft.com/fwlink/?LinkId=235309)|Inserts a security validation into the .aspx page|  
|[ListProperty](http://go.microsoft.com/fwlink/?LinkId=235310)|Returns a property of a specified list.|  
|[ProjectProperty](http://go.microsoft.com/fwlink/?LinkId=235311)|Returns a global property of the current website.|  
|[RssLink](http://go.microsoft.com/fwlink/?LinkId=235312)|Inserts a link to an RSS feed into the .aspx page.|  
|[ScriptLink](http://go.microsoft.com/fwlink/?LinkId=235313)|Provides properties and methods for registering resources, such as scripts, on a page so that they can be requested when the page is rendered.|  
|[Theme](http://go.microsoft.com/fwlink/?LinkId=235314)|Applies a theme to the .aspx page.|  
  
## Debugging a Web Part  
 You can debug a SharePoint project that contains a web part just as you would debug other Visual Studio projects. When you start the Visual Studio debugger, Visual Studio opens the SharePoint site.  
  
 To start to debug your code, add the web part to a web part page in SharePoint.  
  
 For more information about how to debug SharePoint projects, see [Troubleshooting SharePoint Solutions](../VS_officedev/troubleshooting-sharepoint-solutions.md).  
  
## Visual Web Part Limitations  
 Starting in Visual Studio, you can add visual web parts to sandboxed SharePoint solutions and farm solutions. However, visual web parts have the following limitations:  
  
-   Visual web parts don't support replaceable parameters. For more information, see [Replaceable Parameters](../VS_officedev/replaceable-parameters.md).  
  
-   User controls or visual web parts can't be dragged and dropped or copied onto visual web parts. This action causes a build error.  
  
-   Visual web parts don't directly support SharePoint server tokens such as $SPUrl. For more information, see "Token Restrictions in Sandboxed Visual Web Parts" in the topic [Troubleshooting SharePoint Solutions](../VS_officedev/troubleshooting-sharepoint-solutions.md).  
  
-   Visual web parts in a sandboxed solution occasionally get the error, "The sandboxed code execution request was refused because the Sandboxed Code Host Service was too busy to handle the request." For more information about this error, see this post in the [SharePoint Developer Team Blog](http://go.microsoft.com/fwlink/?LinkId=225932).  
  
-   Server-side JavaScript debugging isn't supported in Visual Studio, but client-side JavaScript debugging is supported.  
  
     Although you can add inline JavaScript to a server-side markup file, debugging isn't supported for breakpoints added to the markup. To debug JavaScript, reference an external JavaScript file in the markup file, and then set the breakpoints in the JavaScript file.  
  
-   Debugging of inline [!INCLUDE[vstecasp](../VS_officedev/includes/vstecasp_md.md)] code must be done in the generated code file instead of in the markup file.  
  
-   Visual web parts don't support the use of the `<@ Assembly Src=` directive.  
  
-   SharePoint web controls and some [!INCLUDE[vstecasp](../VS_officedev/includes/vstecasp_md.md)] controls aren't supported in the SharePoint sandboxed environment. If unsupported controls are used on a visual web part in a sandboxed solution, the error, "The type or namespace name 'Theme' does not exist in the namespace 'Microsoft.SharePoint.WebControls'" appears.  
  
 For more information about sandboxed solutions, see [Differences Between Sandboxed and Farm Solutions](../VS_officedev/differences-between-sandboxed-and-farm-solutions.md).  
  
## Creating Older Style SharePoint-Based Web Parts  
 You can use the templates in Visual Studio to create custom [!INCLUDE[vstecasplong](../VS_officedev/includes/vstecasplong_md.md)] web parts for SharePoint. [!INCLUDE[vstecasplong](../VS_officedev/includes/vstecasplong_md.md)] web parts are built on top of the [!INCLUDE[vstecasp](../VS_officedev/includes/vstecasp_md.md)] web part infrastructure and are the recommended type for new projects.  
  
 In very few cases, you might have to create a web part by using the older style SharePoint-based web part. You can use Visual Studio to create these types of web parts, but Visual Studio doesn't provide any templates that are designed specifically to help you create them.  
  
 For more information about when you might want to create an older style SharePoint-based web part, see [Web Part Infrastructure in Windows SharePoint Services](http://go.microsoft.com/fwlink/?LinkId=169290). For more information about how to create a web part by using the older style SharePoint-based web part, see [Walkthrough Creating a Basic SharePoint Web Part](http://go.microsoft.com/fwlink/?LinkId=169288).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Create a SharePoint Web Part](../VS_officedev/how-to--create-a-sharepoint-web-part.md)|Shows you how to create web parts for SharePoint pages.|  
|[How to: Create a SharePoint Web Part by Using a Designer](../VS_officedev/how-to--create-a-sharepoint-web-part-by-using-a-designer.md)|Shows you how to create web parts for SharePoint by using a visual design surface.|  
|[How to: Create a User Control for a SharePoint Application Page or Web Part](../VS_officedev/how-to--create-a-user-control-for-a-sharepoint-application-page-or-web-part.md)|Shows you how to create custom, reusable controls that can be consumed by application pages and web parts that run in SharePoint.|  
|[Walkthrough: Creating a Web Part for SharePoint](../VS_officedev/walkthrough--creating-a-web-part-for-sharepoint.md)|Describes how to design a web part for SharePoint.|  
|[Walkthrough: Creating a Web Part for SharePoint by Using a Designer](../VS_officedev/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer.md)|Describes how to design a web part for SharePoint by dragging controls to a visual design surface.|  
|[Walkthrough: Creating a Silverlight Web Part that Displays OData for SharePoint](../VS_officedev/walkthrough--creating-a-silverlight-web-part-that-displays-odata-for-sharepoint.md)|Describes how to design a web part for SharePoint that hosts a Silverlight application and displays data from SharePoint lists.|  
|[Working with Visual Web Developer](assetId:///9c31f93b-c8fb-4599-9b14-6194ec8c7539)|Describes how to use the designer that appears when you open a webpage in your project.|  
  
  