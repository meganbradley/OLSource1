---
title: "MSBuild Well-known Item Metadata"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, item metadata"
  - "MSBuild, well-known item metadata"
ms.assetid: b5e791b5-c68f-4978-ad8a-9247d03bb6c0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Well-known Item Metadata
The following table describes the metadata assigned to every item upon creation. In each example, the following item declaration was used to include the file <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the project.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
|Item Metadata|Description|  
|-------------------|-----------------|  
|%(FullPath)|Contains the full path of the item. For example:\<br />\<br /> <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|%(RootDir)|Contains the root directory of the item. For example:\<br />\<br /> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|%(Filename)|Contains the file name of the item, without the extension. For example:\<br />\<br /> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|%(Extension)|Contains the file name extension of the item. For example:\<br />\<br /> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|%(RelativeDir)|Contains the path specified in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute, up to the final backslash (\\). For example:\<br />\<br /> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|%(Directory)|Contains the directory of the item, without the root directory. For example:\<br />\<br /> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|%(RecursiveDir)|If the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute contains the wildcard \*\*, this metadata specifies the part of the path that replaces the wildcard. For more information on wildcards, see [How To: Build All Files in a Directory](../vs140/how-to--select-the-files-to-build.md).\<br />\<br /> If the folder *C:\MySolution\MyProject\Source\\* contains the file Program.cs, and if the project file contains this item:\<br />\<br /> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>\<br />\<br /> then the value of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> would be *MySolution\MyProject\Source\\*.|  
|%(Identity)|The item specified in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attribute.. For example:\<br />\<br /> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|%(ModifiedTime)|Contains the timestamp from the last time the item was modified. For example:\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|%(CreatedTime)|Contains the timestamp from when the item was created. For example:\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|%(AccessedTime)|Contains the timestamp from the last time the item was accessed.\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
  
## See Also  
 [MSBuild Items](../vs140/msbuild-items.md)   
 [MSBuild Batching](../vs140/msbuild-batching.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)