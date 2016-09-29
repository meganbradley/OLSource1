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
**#pragma region** lets you specify a block of code that you can expand or collapse when using the [outlining feature](../VS_csharp/outlining.md) of the Visual Studio Code Editor.  
  
## Syntax  
  
```  
#pragma region name  
#pragma endregion comment  
```  
  
#### Parameters  
 `comment`(optional)  
 A comment that will display in the code editor.  
  
 *name*(optional)  
 The name of the region.  This name will display in the code editor.  
  
## Remarks  
 **#pragma endregion** marks the end of a **#pragma region** block.  
  
 A `#region` block must be terminated with **#pragma endregion**.  
  
## Example  
  
```  
// pragma_directives_region.cpp  
#pragma region Region_1  
void Test() {}  
void Test2() {}  
void Test3() {}  
#pragma endregion Region_1  
  
int main() {}  
```  
  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../VS_csharp/pragma-directives-and-the-__pragma-keyword.md)