---
title: "#Region Directive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Region"
  - "vb.#Region"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Visual Basic compiler, compiler directives"
  - "#region directive"
  - "region directive (#region)"
  - "#Region keyword"
ms.assetid: 90a6a104-3cbf-47d0-bdc4-b585d0921b87
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #Region Directive
Collapses and hides sections of code in Visual Basic files.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. String that acts as the title of a region when it is collapsed. Regions are collapsed by default.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Terminates the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block.|  
  
## Remarks  
 Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive to specify a block of code to expand or collapse when using the outlining feature of the Visual Studio Code Editor. You can place, or *nest*, regions within other regions to group similar regions together.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directive.  
  
 [!code[VbVbalrConditionalComp#4](../vs140/codesnippet/VisualBasic/sharpregion-directive_1.vb)]  
  
## See Also  
 [#If...Then...#Else Directives](../vs140/sharpif...then...sharpelse-directives.md)   
 [Outlining](../vs140/outlining.md)   
 [How to: Collapse and Hide Sections of Code](../vs140/how-to--collapse-and-hide-sections-of-code--visual-basic-.md)