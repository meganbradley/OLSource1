---
title: "&lt;PackageFiles&gt; Element (Bootstrapper)"
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
  - "<PackageFiles> element [bootstrapper]"
ms.assetid: 3ea252d7-18a3-47d8-af83-47feebcfe82b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;PackageFiles&gt; Element (Bootstrapper)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element contains <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements, which define the installation packages executed as a result of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional. If set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the installer will only download files referenced from the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element. If set to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, all files will be downloaded.\<br />\<br /> If set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the installer will behave the same as if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and otherwise will behave the same as if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. This setting can be useful to allow packages that are themselves bootstrappers to execute their own behavior in a HomeSite scenario.\<br />\<br /> The default is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
  
## PackageFile  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element is a child of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element. A <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element must have at least one <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> element.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Required. The name of the package file. This is the name that the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element will reference when it defines the conditions under which a package installs. This value is also used as a key into the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> table to retrieve the localized name that tools such as [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] will use to describe the package.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional. The location of the package on the remote server, if it is not included with the installer.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Optional. Specifies whether the bootstrapper should copy the package file onto the disk at build time. The default is true.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|The encrypted public key of the package's certificate signer. Required if <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is used; otherwise, optional.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Optional. An SHA1 hash of the package file. This is used to verify the integrity of the file at install time. If the identical hash cannot be computed from the package file, the package will not be installed.|  
  
## Example  
 The following code example defines packages for the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] redistributable package and its dependencies, such as the Windows Installer.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [\<Product> Element (ClickOnce Bootstrapper)](../vs140/-product--element--bootstrapper-.md)   
 [\<Package> Element (ClickOnce Bootstrapper)](../vs140/-package--element--bootstrapper-.md)   
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)