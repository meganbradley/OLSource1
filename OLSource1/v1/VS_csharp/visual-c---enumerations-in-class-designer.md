---
title: "Visual C++ Enumerations in Class Designer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Class Designer [Visual Studio], enumerations"
ms.assetid: 11e90ba1-18cd-44f8-9e26-e3746a7a19d1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual C++ Enumerations in Class Designer
Class Designer supports C++ `enum` and scoped `enum class` types. Following is an example:  
  
```  
enum CardSuit {  
   Diamonds = 1,  
   Hearts = 2,  
   Clubs = 3,  
   Spades = 4  
};  
  
// or...  
enum class CardSuit {  
   Diamonds = 1,  
   Hearts = 2,  
   Clubs = 3,  
   Spades = 4  
};  
  
```  
  
 A C++ enumeration shape in a class diagram looks and works like a structure shape, except that the label reads **Enum** or **Enum class**, it is pink instead of blue, and it has a colored border on the left and top margins. Both enumeration shapes and structure shapes have square corners.  
  
 For more information about using the `enum` type, see [C++ Enumeration Declarations](../VS_csharp/enumerations--c---.md).  
  
## See Also  
 [Working with Visual C++ Code in Class Designer](../VS_csharp/working-with-visual-c---code--class-designer-.md)   
 [C++ Enumeration Declarations](../VS_csharp/enumerations--c---.md)