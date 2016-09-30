---
title: "Using IDispEventSimpleImpl"
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
  - "IDispEventSimpleImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDispEventSimpleImpl class, using"
ms.assetid: 8640ad1a-4bd0-40a5-b5e4-7322685d7aab
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using IDispEventSimpleImpl
When using <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to handle events, you will need to:  
  
-   Derive your class from [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md).  
  
-   Add an [event sink map](../vs140/begin_sink_map.md) to your class.  
  
-   Define [_ATL_FUNC_INFO](../vs140/_atl_func_info-structure.md) structures describing the events.  
  
-   Add entries to the event sink map using the [SINK_ENTRY_INFO](../vs140/sink_entry_info.md) macro.  
  
-   Implement the methods that you're interested in handling.  
  
-   Advise and unadvise the event source.  
  
## Example  
 The example below shows you how to handle the **DocumentChange** event fired by Word's **Application** object. This event is defined as a method on the **ApplicationEvents** dispinterface.  
  
 The example is from the [ATLEventHandling sample](../vs140/visual-c---samples.md).  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 The example uses <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to generate the required header files from Word's type library. If you want to use this example with other versions of Word, you must specify the correct mso dll file. For example, Office 2000 provides mso9.dll and OfficeXP provides mso.dll. This code is simplified from stdafx.h:  
  
 [!code[NVC_ATL_EventHandlingSample#1](../vs140/codesnippet/CPP/using-idispeventsimpleimpl_1.h)]  
  
 The only information from the type library actually used in this example is the CLSID of the Word **Application** object and the IID of the **ApplicationEvents** interface. This information is only used at compile time.  
  
 The following code appears in Simple.h. The relevant code is noted by comments:  
  
 [!code[NVC_ATL_EventHandlingSample#3](../vs140/codesnippet/CPP/using-idispeventsimpleimpl_2.h)]  
  
 The following code is from Simple.cpp:  
  
 [!code[NVC_ATL_EventHandlingSample#4](../vs140/codesnippet/CPP/using-idispeventsimpleimpl_3.cpp)]  
  
## See Also  
 [Event Handling](../vs140/event-handling-and-atl.md)   
 [ATLEventHandling Sample](../vs140/visual-c---samples.md)