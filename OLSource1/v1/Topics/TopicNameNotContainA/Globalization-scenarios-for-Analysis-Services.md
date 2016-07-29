---
title: "Globalization scenarios for Analysis Services"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e8af85ff-ef33-4659-a003-bb34578eb2a2
caps.latest.revision: 40
manager: mblythe
---
# Globalization scenarios for Analysis Services
[!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] stores and manipulates multilingual data and metadata for both tabular and multidimensional data models. Data storage is Unicode (UTF-16), in character sets that use Unicode encoding. If you load ANSI data into a data model, characters are stored using Unicode equivalent code points.  
  
 The implications of Unicode support means that [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] can store data in any of the languages supported by the Windows client and server operating systems, allowing read, write, sort, and comparison of data in any character set used on a Windows computer. BI client applications consuming [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] data can represent data in the user's language of choice, assuming the data exists in that language in the model.  
  
 Language support can mean different things to different people. The following list addresses a few common questions related to how Analysis Services supports languages.  
  
-   Data, as already noted, is stored in any Unicode-encoded character set found on a Windows client operating system.  
  
-   Metadata, such as object names, can be translated. Although support varies by model type, both multidimensional and tabular models support the addition of translated strings inside the model. You can define multiple translations, and then use a locale identifier to determine which translation is returned to the client. See [Features](#bkmk_features) below for more details  
  
-   Error, warning, and informational messages returned by the [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] engine (msmdsrv) are localized into the 43 languages supported by Office and Office 365. No configuration is required to get messages in a specific language. The locale of the client application determines which strings are returned.  
  
-   Configuration file (msmdsrv.ini) and AMO PowerShell are in English only.  
  
-   Log files will contain a mix of English and localized messages, assuming you have installed a language pack on the Windows server that Analysis Services runs on.  
  
-   Documentation and tools, such as [!INCLUDE[ssManStudio](../../Topics/TopicNameContainA/includes/ssManStudio_md.md)] and [!INCLUDE[ssBIDevStudio](../../Topics/TopicNameContainA/includes/ssBIDevStudio_md.md)], are translated into these languages: Chinese Simplified, Chinese Traditional, French, German, Italian, Japanese, Korean, Portuguese (Brazil), Russian, and Spanish. Culture is specified during installation.  
  
 For multidimensional models, Analysis Services lets you set language, collation, and translations independently throughout the object hierarchy.  For tabular models, you can only add translations: language and collation are inherited by the host operating system.  
  
 Scenarios enabled through Analysis Services globalization features include:  
  
-   One data model provides multiple translated captions so that field names and values appear in the user's language of choice. For companies operating in bi-lingual countries such as Canada, Belgium, or Switzerland, supporting multiple languages across client and server applications is a standard coding requirement. This scenario is enabled through translations and currency conversions. See [Features](#bkmk_features) below for details and links.  
  
-   Development and production environments are geo-located in different countries. It's increasingly common to develop a solution in one country and then deploy it another. Knowing how to set language and collation properties is essential if you are tasked with preparing a solution developed in one language, for deployment on a server that uses a different language pack. Setting these properties allows you to override the inherited defaults that you get from the original host system. See [Languages and Collations (Analysis Services)](../../Topics/TopicNameNotContainA/Languages-and-Collations--Analysis-Services-.md) for details about setting properties.  
  
##  <a name="bkmk_features"></a> Features for building a globalized multi-lingual solution  
 At the client level, globalized applications that consume or manipulate [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] multidimensional data can use the multilingual and multicultural features in [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)].  
  
 You can retrieve data and metadata from [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] objects on which translations have been defined automatically by providing a locale identifier when connecting to an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] instance.  
  
 See [Globalization Tips and Best Practices (Analysis Services)](../../Topics/TopicNameNotContainA/Globalization-Tips-and-Best-Practices--Analysis-Services-.md) for design and coding practices that can help you avoid problems related to multi-language data.  
  
||||  
|-|-|-|  
|**Capability**|**Tabular**|**Multidimensional**|  
|[Languages and Collations (Analysis Services)](../../Topics/TopicNameNotContainA/Languages-and-Collations--Analysis-Services-.md)|Inherited from the operating system.|Inherited, but with the ability to override both language and collation for major objects in the model hierarchy.|  
|Scope of translation support|Captions and descriptions.|Translations can be created for object names, captions,  identifiers, and descriptions, can also be in any Unicode language and script. This is true even when the tools and environment are in another language. For example, in a development environment that uses English language and a Latin collation throughout the stack, you can include in your model an object that uses Cyrillic characters in its name.|  
|Implementing translation support|Create using [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] to generate translation files that you fill in and then import back into the model.<br /><br /> See [Translations in Tabular models (Analysis Services)](../../Topics/TopicNameNotContainA/Translations-in-Tabular-models--Analysis-Services-.md) for details.|Create using[!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] to define the translations for the caption, description, and account types for cubes and measures, dimension and attributes.<br /><br /> See [Translations in Multidimensional Models (Analysis Services)](../../Topics/TopicNameNotContainA/Translations-in-Multidimensional-Models--Analysis-Services-.md) for more information. A lesson on how to use this feature can be found in [Lesson 9: Defining Perspectives and Translations](assetId:///a040fa65-d5d6-4156-9f2c-307a4d18e1a6) of the [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] tutorial.|  
|Currency conversion|Not available.|Currency conversion is through specialized MDX scripts that convert measures containing currency data. You can use the Business Intelligence Wizard in [!INCLUDE[ss_dtbi](../../Topics/TopicNameNotContainA/includes/ss_dtbi_md.md)] to generate an MDX script that uses a combination of data and metadata from dimensions, attributes, and measure groups to convert measures containing currency data. See [Currency Conversions (Analysis Services)](../../Topics/TopicNameNotContainA/Currency-Conversions--Analysis-Services-.md).|  
  
## See Also  
 [Translation support in Analysis Services](../../Topics/TopicNameNotContainA/Translation-support-in-Analysis-Services.md)   
 [Internationalization for Windows Applications](http://msdn.microsoft.com/library/windows/desktop/dd318661%28v=vs.85%29.aspx)   
 [Go Global Developer Center](http://msdn.microsoft.com/goglobal/bb871628.aspx)   
 [Writing Windows Store apps with locale-based adaptive design](http://blogs.windows.com/buildingapps/2014/03/06/writing-windows-store-apps-with-locale-based-adaptive-design/)   
 [Developing Universal Windows Apps with C# and XAML](http://www.microsoftvirtualacademy.com/training-courses/developing-universal-windows-apps-with-c-and-xaml)