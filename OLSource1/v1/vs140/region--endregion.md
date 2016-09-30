---
title: "region, endregion"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc-pragma.endregion"
  - "endregion_CPP"
  - "region_CPP"
  - "vc-pragma.region"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, region"
  - "pragmas, endregion"
  - "endregion pragma"
  - "region pragma"
ms.assetid: c697f807-622f-4796-851b-68a42bbecd84
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# region, endregion
**#pragma region** lets you specify a block of code that you can expand or collapse when using the [outlining feature](../vs140/outlining.md) of the Visual Studio Code Editor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>(optional)  
 A comment that will display in the code editor.  
  
 *name*(optional)  
 The name of the region.  This name will display in the code editor.  
  
## Remarks  
 **#pragma endregion** marks the end of a **#pragma region** block.  
  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block must be terminated with **#pragma endregion**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)