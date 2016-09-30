---
title: "Statement Completion for Identifiers"
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
  - "IntelliSense [JavaScript], statement completion"
  - "statement completion, JavaScript IntelliSense"
ms.assetid: c2cd4945-c67e-471b-8057-96cfd25f7fb2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Statement Completion for Identifiers
JavaScript doesn't allow explicit typing for variable declarations. As a result, IntelliSense can't always provide completion lists for objects. This can occur in various situations. Following are a few common ones.  
  
-   A parameter is declared, but it has not been called elsewhere in the active document, as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   An object is in a function that is called in response to an event. At design time, the IntelliSense engine cannot determine the type of the objects used in this situation.  
  
     If the IntelliSense engine can determine that the event should be called, typically through the use of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for the event in the active document, more accurate IntelliSense information is provided.  
  
 When IntelliSense is unable to identify an object, the IntelliSense engine populates the completion list with named entities, or identifiers, that are present in the active document. When the completion list contains these identifiers, information icons appear next to them. In addition, a tooltip for each identifier indicates that the expression is unknown. The following illustration shows statement completion options for an object of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that can't be identified because the object and its properties are undefined. However, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> property is available in the identifier list because it has been used in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function.  
  
 **Completion options for an object that can't be identified**  
  
 ![JavaScript IntelliSense for identifiers](../vs140/media/js_intellisense_identifiers.png "js_intellisense_identifiers")  
  
 You can override the completion list for an object by using XML documentation comments or JavaScript IntelliSense extensibility features. Using these features, you can provide type information and more descriptive IntelliSense information when it might not otherwise be available. For more information, see [Extending JavaScript IntelliSense](../vs140/extending-javascript-intellisense.md) and [How to: Create JavaScript XML Documentation Comments](../vs140/create-xml-documentation-comments-for-javascript-intellisense.md).  
  
## See Also  
 [JavaScript IntelliSense Overview](../vs140/javascript-intellisense.md)