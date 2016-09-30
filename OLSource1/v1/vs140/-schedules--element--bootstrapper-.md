---
title: "&lt;Schedules&gt; Element (Bootstrapper)"
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
  - "<Schedules> element [bootstrapper]"
ms.assetid: 28d094cf-64f5-42b1-bd8a-3697082aab4f
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;Schedules&gt; Element (Bootstrapper)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> element contains <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> elements, which define specific times at which commands defined by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element should be run.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element is a child of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element. Each <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element might have at most one <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element has no attributes.  
  
## Schedule  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element is a child of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element. A <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element must have at least one <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Required. The name of the schedule item. This corresponds to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> property of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element. When a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> references the named schedule, it will only be executed at the time indicated by that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element. Schedules may also be associated with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> elements, which restrict these conditional tests to executing on the specified schedule. For more information, see [\<Commands> Element (ClickOnce Bootstrapper)](../vs140/-commands--element--bootstrapper-.md).|  
  
 A given <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element may have exactly one of the following children.  
  
## BuildList  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element instructs the installer to execute a command immediately after the bootstrapping application is started.  
  
## BeforePackage  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> element instructs the installer to execute a command before the specified package is installed.  
  
## AfterPackage  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> element instructs the installer to execute a command after the specified package is installed.  
  
## See Also  
 [\<Product> Element (ClickOnce Bootstrapper)](../vs140/-product--element--bootstrapper-.md)   
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)