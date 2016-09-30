---
title: "&#39;ParamArray&#39; cannot be applied to the first parameter of an extension method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc36554"
  - "bc36554"
helpviewer_keywords: 
  - "BC36554"
ms.assetid: 0778a854-246f-4c2b-943d-ea8883b3aa6f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;ParamArray&#39; cannot be applied to the first parameter of an extension method
'ParamArray' cannot be applied to the first parameter of an extension method. The first parameter specifies which type to extend.  
  
 The first parameter of an extension method specifies the data type that the method extends. Therefore, the first parameter is required and cannot be optional. Because a parameter array is automatically optional, it is not valid as the first argument of an extension method.  
  
> [!NOTE]
>  When the method is executed, the instance of the extended data type that invokes the method becomes the argument for the first parameter of the method. For example, the instance <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the argument for the first parameter, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, in extension method <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 **Error ID:** BC36554  
  
### To correct this error  
  
-   If the parameter array does not specify the data type you want to extend, add a new first parameter that specifies this type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   If the parameter array does specify the data type you want to extend, consider changing it to a regular array, requiring an argument, instead of a parameter array. Regular arrays can be extended.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)   
 [Parameter Arrays](../vs140/parameter-arrays--visual-basic-.md)   
 [Optional Parameters](../vs140/optional-parameters--visual-basic-.md)