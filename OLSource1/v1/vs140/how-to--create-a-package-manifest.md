---
title: "How to: Create a Package Manifest"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "package files [Windows Installer]"
  - "package files [ClickOnce]"
  - "prerequisites, custom bootstrapper package"
  - "dependencies, custom bootstrapper packages"
ms.assetid: 5aecc507-2764-42f2-ae6f-c227971cf0af
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Package Manifest
To deploy prerequisites for your application, you can use a bootstrapper package. A bootstrapper package contains a single product manifest file but a package manifest for each locale. Shared functionality across different localized versions should go into the product manifest.  
  
 For more information about package manifests, see [How to: Create a Package Manifest](../vs140/how-to--create-a-product-manifest.md).  
  
## Creating the Package Manifest  
  
#### To create the package manifest  
  
1.  Create a directory for the bootstrapper package. This example uses C:\package.  
  
2.  Create a subdirectory with the name of the locale, such as en for English.  
  
3.  In Visual Studio, create an XML file that is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and save it to the C:\package\en folder.  
  
4.  Add XML to list the name of the bootstrapper package, the culture for this localized package manifest, and the optional license agreement. The following XML uses the variables <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which are defined in a later element.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
5.  Add XML to list all the files that are in the locale-specific directory. The following XML uses a file that is named eula.txt that is applicable for the **en** locale.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
6.  Add XML to define localizable strings for the bootstrapper package. The following XML adds error strings for the en locale.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
7.  Copy the C:\package folder to the Visual Studio bootstrapper directory. For Visual Studio 2010, this is the \Program Files\Microsoft SDKs\Windows\v7.0A\Bootstrapper\Packages directory.  
  
## Example  
 The package manifest contains locale-specific information, such as error messages, software license terms, and language packs.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)