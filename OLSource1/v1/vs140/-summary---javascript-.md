---
title: "&lt;summary&gt; (JavaScript)"
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
  - "summary JavaScript XML tag"
  - "<summary> JavaScript XML tag"
ms.assetid: 6540582d-bdb3-42ec-ad2f-c176783e6f9c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;summary&gt; (JavaScript)
Specifies the description for a function or method.  
  
## Syntax  
  
```  
<summary locid="descriptionID">description  
</summary>  
```  
  
#### Parameters  
 `locid`  
 Optional. The identifier for localization information about the function or method. The identifier is either a member ID or it corresponds to the `name` attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [<loc\>](../vs140/-loc---javascript-.md) element.  
  
 `description`  
 Optional. A description of the function or method.  
  
## Remarks  
 The elements used to annotate functions, which include [<summary\>](../vs140/-summary---javascript-.md), [<param\>](../vs140/-param---javascript-.md), and [<returns\>](../vs140/-returns---javascript-.md), must be placed in the function body before any statements.  
  
## Example  
 The following code shows how to use the `<summary>` element.  
  
```javascript  
function areaFunction(radiusParam)  
{  
    /// <summary>Determines the area of a circle when supplied a radius parameter.</summary>  
    /// <param name="radiusParam" type="Number">The radius of the circle.</param>  
    /// <returns type="Number">The area.</returns>  
    var areaVal;  
    areaVal = Math.PI * radiusParam * radiusParam;  
    return areaVal;  
}  
  
```  
  
## See Also  
 [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md)