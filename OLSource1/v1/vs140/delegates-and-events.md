---
title: "Delegates and Events"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__event keyword [C++]"
  - "delegate keyword [C++]"
  - "delegates [C++], upgrading from Managed Extensions for C++"
  - "__delegate keyword"
  - "events [C++], upgrading from Managed Extensions for C++"
  - "event keyword [C++]"
ms.assetid: 3505c626-7e5f-4492-a947-0e2248f7b84a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Delegates and Events
The way to declare delegates and events has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 The double underscore is no longer needed, as shown in the following sample. Here a sample code in Managed Extensions:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The same code in the new syntax looks as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Events (and delegates) are reference types, which is clear in the new syntax because of the use of the hat (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  Events support both an explicit declaration syntax and the trivial form shown in the preceding code. In the explicit form, the user specifies the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> methods associated with the event. (Only the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> methods are required; the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method is optional.)  
  
 Under Managed Extensions, if you provide these methods, you do not also provide an explicit event declaration, but you must decide on a name for the event that is not present. Each method is specified in the form <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, as in the following example taken from the Managed Extensions specification:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new syntax simplifies the declaration, as the following translation demonstrates. An event specifies the two or three methods enclosed in a pair of braces  and placed immediately after the declaration of the event and its associated delegate type, as shown here:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Member Declarations within a Class or Interface](../vs140/member-declarations-within-a-class-or-interface--c---cli-.md)   
 [delegate](../vs140/delegate---c---component-extensions-.md)   
 [event](../vs140/event---c---component-extensions-.md)