---
title: "TOOLTIPTEXT Structure"
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
  - "TOOLTIPTEXT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TOOLTIPTEXT structure"
  - "tool tips [C++], notifications"
ms.assetid: 547591bf-80f5-400e-a2a7-0708cfffbb5d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TOOLTIPTEXT Structure
In writing your [tool tip notification handler](../vs140/handling-ttn_needtext-notification-for-tool-tips.md), you need to use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> structure. The members of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>structure are:  
  
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
 Identifies the tool that needs text. The only member of this structure you might need is the control's command ID. The control's command ID will be in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structure, accessed with the syntax <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. See [NMHDR](http://msdn.microsoft.com/library/windows/desktop/bb775514) for a discussion of members of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Address of a string to receive the text for a tool.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Buffer that receives the tool tip text. An application can copy the text to this buffer as an alternative to specifying a string address.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Handle of the instance that contains a string to be used as the tool tip text. If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is the address of the tool tip text, this member is NULL.  
  
 When you handle the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> notification message, specify the string to be displayed in one of the following ways:  
  
-   Copy the text to the buffer specified by the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member.  
  
-   Copy the address of the buffer that contains the text to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member.  
  
-   Copy the identifier of a string resource to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> member, and copy the handle of the instance that contains the resource to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> member.  
  
## See Also  
 [Tool Tips in Windows Not Derived from CFrameWnd](../vs140/tool-tips-in-windows-not-derived-from-cframewnd.md)