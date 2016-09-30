---
title: "How to: Publish Events that Conform to .NET Framework Guidelines (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "events [C#], implementation guidelines"
ms.assetid: 9310ae16-8627-44a2-b08c-05e5976202b1
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Publish Events that Conform to .NET Framework Guidelines (C# Programming Guide)
The following procedure demonstrates how to add events that follow the standard [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] pattern to your classes and structs. All events in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] class library are based on the \<xref:System.EventHandler*> delegate, which is defined as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  The [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)] introduces a generic version of this delegate, <xref:System.EventHandler<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>1*> .) Declare a delegate in your publishing class. Give it a name that ends with *EventHandler*. The second parameter specifies your custom EventArgs type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Declare the event in your publishing class by using one of the following steps.  
  
    1.  If you have no custom EventArgs class, your Event type will be the non-generic EventHandler delegate. You do not have to declare the delegate because it is already declared in the \<xref:System*> namespace that is included when you create your C# project. Add the following code to your publisher class.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
    2.  If you are using the non-generic version of \<xref:System.EventHandler*> and you have a custom class derived from \<xref:System.EventArgs*>, declare your event inside your publishing class and use your delegate from step 2 as the type.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
    3.  If you are using the generic version, you do not need a custom delegate. Instead, in your publishing class, you specify your event type as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, substituting the name of your own class between the angle brackets.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates the previous steps by using a custom EventArgs class and \<xref:System.EventHandler`1*> as the event type.  
  
 [!code[csProgGuideEvents#2](../vs140/codesnippet/CSharp/how-to--publish-events-that-conform-to-.net-framework-guidelines--csharp-programming-guide-_1.cs)]  
  
## See Also  
 \<xref:System.Delegate*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Events (C# Programmer's Reference)](../vs140/events--csharp-programming-guide-.md)   
 [Delegates (C# Programmer's Reference)](../vs140/delegates--csharp-programming-guide-.md)