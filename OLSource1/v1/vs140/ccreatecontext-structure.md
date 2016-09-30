---
title: "CCreateContext Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CCreateContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCreateContext structure"
ms.assetid: 337a0e44-d910-49a8-afc0-c7207666a9dc
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCreateContext Structure
The framework uses the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure when it creates the frame windows and views that are associated with a document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a structure and does not have a base class.  
  
 When you create a window, the values in this structure provide the information used to connect the components of a document to the view of its data. You only have to use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if you are overriding parts of the creation process.  
  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure contains pointers to the document, the frame window, the view, and the document template. It also contains a pointer to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that identifies the type of view to create. The run-time class information and the current document pointer are used to create a new view dynamically. The following table suggests how and when each <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member might be used:  
  
|Member|Type|What it is for|  
|------------|----------|--------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> of the new view to create.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The existing document to be associated with the new view.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The document template associated with the creation of a new MDI frame window.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The original view on which additional views are modeled, as in the creation of splitter window views or the creation of a second view on a document.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The frame window on which additional frame windows are modeled, as in the creation of a second frame window on a document.|  
  
 When a document template creates a document and its associated components, it validates the information stored in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> structure. For example, a view should not be created for a nonexistent document.  
  
> [!NOTE]
>  All of the pointers in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are optional and can be <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if unspecified or unknown.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is used by the member functions listed under "See Also." Consult the descriptions of these functions for specific information if you plan to override them.  
  
 Here are a few general guidelines:  
  
-   When passed as an argument for window creation, as in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, the create context specifies what the new window should be connected to. For most windows, the entire structure is optional and a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> pointer can be passed.  
  
-   For overridable member functions, such as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> argument is optional.  
  
-   For member functions involved in view creation, you must provide enough information to create the view. For example, for the first view in a splitter window, you must supply the view class information and the current document.  
  
 In general, if you use the framework defaults, you can ignore <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. If you attempt more advanced modifications, the Microsoft Foundation Class Library source code or the sample programs, such as VIEWEX, will guide you. If you do forget a required parameter, a framework assertion will tell you what you forgot.  
  
 For more information on <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, see the MFC sample [VIEWEX](../vs140/visual-c---samples.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::Create](../vs140/cframewnd-class.md#cframewnd__create)   
 [CFrameWnd::LoadFrame](../vs140/cframewnd-class.md#cframewnd__loadframe)   
 [CFrameWnd::OnCreateClient](../vs140/cframewnd-class.md#cframewnd__oncreateclient)   
 [CSplitterWnd::Create](../vs140/csplitterwnd-class.md#csplitterwnd__create)   
 [CSplitterWnd::CreateView](../vs140/csplitterwnd-class.md#csplitterwnd__createview)   
 [CWnd::Create](../vs140/cwnd-class.md#cwnd__create)