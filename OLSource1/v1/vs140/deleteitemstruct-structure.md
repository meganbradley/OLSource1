---
title: "DELETEITEMSTRUCT Structure"
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
  - "DELETEITEMSTRUCT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DELETEITEMSTRUCT structure"
ms.assetid: 48d3998c-f4a8-402a-bf90-df3770a78685
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DELETEITEMSTRUCT Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure describes a deleted owner-drawn list-box or combo-box item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies **ODT_LISTBOX** (an owner-drawn list box) or **ODT_COMBOBOX** (an owner-drawn combo box).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the identifier of the list box or combo box.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies index of the item in the list box or combo box being removed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Identifies the control.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies application-defined data for the item. This value is passed to the control in the **lParam** parameter of the message that adds the item to the list box or combo box.  
  
## Remarks  
 When an item is removed from the list box or combo box or when the list box or combo box is destroyed, Windows sends the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> message to the owner for each deleted item. The **lParam** parameter of the message contains a pointer to this structure.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CWnd::OnDeleteItem](../vs140/cwnd--ondeleteitem.md)