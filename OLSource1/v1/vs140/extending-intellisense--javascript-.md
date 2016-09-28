---
title: "Extending IntelliSense (JavaScript)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 338ccaa0-9f2e-4be3-9846-66f73537be17
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Extending IntelliSense (JavaScript)
Visual Studio provides a mechanism to extend and customize IntelliSense for third-party JavaScript libraries that are added to a project. By default, third party libraries already benefit from some IntelliSense support:  
  
-   Descriptions of variables, functions, and objects will show up in IntelliSense when the description is included in a standard JavaScript comment tag (//) that precedes the code element.  
  
-   Type information will show up in IntelliSense if you provide the type information using standard JSDoc comments (/**/) or [XML documentation comments](../vs140/xml-documentation-comments--javascript-.md).  
  
 Alternatively, you can use the built-in extensibility mechanism and API for JavaScript to provide type information or to customize IntelliSense in other ways. To extend JavaScript IntelliSense using the extensibility mechanism:  
  
-   Include a *libraryname*.intellisense.js file in the same directory as the library for which you are providing IntelliSense.  
  
-   In the *libraryname*.intellisense.js file, write code to subscribe to events that are exposed by the `intellisense` object of the language service. This allows you to customize IntelliSense behavior.  
  
 For more information and code examples, see [Extending JavaScript IntelliSense](../vs140/extending-javascript-intellisense.md).  
  
## See Also  
 [Customizing IntelliSense for RequireJS](../vs140/customizing-intellisense-for-requirejs.md)