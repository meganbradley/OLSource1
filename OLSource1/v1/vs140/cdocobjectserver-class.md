---
title: "CDocObjectServer Class"
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
  - "CDocObjectServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document object server"
  - "CDocObjectServer class"
  - "servers [C++], ActiveX documents"
  - "docobject server"
  - "servers [C++], doc objects"
  - "ActiveX documents [C++], document server"
ms.assetid: 18cd0dff-0616-4472-b8d9-66c081bc383a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServer Class
Implements the additional OLE interfaces needed to make a normal <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> server into a full DocObject server: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDocObjectServer::CDocObjectServer](#cdocobjectserver__cdocobjectserver)|Constructs a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDocObjectServer::ActivateDocObject](#cdocobjectserver__activatedocobject)|Activates the document object server, but does not show it.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDocObjectServer::OnActivateView](#cdocobjectserver__onactivateview)|Displays the DocObject view.|  
|[CDocObjectServer::OnApplyViewState](#cdocobjectserver__onapplyviewstate)|Restores the state of the DocObject view.|  
|[CDocObjectServer::OnSaveViewState](#cdocobjectserver__onsaveviewstate)|Saves the state of the DocObject view.|  
  
## Remarks  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and works closely with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to expose the interfaces.  
  
 A DocObject server document can contain [CDocObjectServerItem](../vs140/cdocobjectserveritem-class.md) objects, which represent the server interface to DocObject items.  
  
 To customize your DocObject server, derive your own class from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and override its view setup functions, [OnActivateView](#cdocobjectserver__onactivateview), [OnApplyViewState](#cdocobjectserver__onapplyviewstate), and [OnSaveViewState](#cdocobjectserver__onsaveviewstate). You will need to provide a new instance of your class in response to framework calls.  
  
 For further information on DocObjects, see [CDocObjectServerItem](../vs140/cdocobjectserveritem-class.md) and [COleCmdUI](../vs140/colecmdui-class.md) in the                 *MFC Reference*. Also see [Internet First Steps: Active Documents](../vs140/active-documents-on-the-internet.md) and [Active Documents](../vs140/active-documents-on-the-internet.md).  
  
 Also see the following Knowledge Base article:  
  
-   Q247382 : PRB: ToolTips for Controls in ActiveX Document Server Are Hidden by the ActiveX Document Container  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdocob.h  
  
##  \<a name="cdocobjectserver__activatedocobject">\</a>  CDocObjectServer::ActivateDocObject  
 Call this function to activate (but not show) the document object server.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>'s **ActivateMe** method, but does not show the view because it waits for specific instructions on how to set up and display the view, given in the call to [CDocObjectServer::OnActivateView](#cdocobjectserver__onactivateview).  
  
 Together, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> activate and display the DocObject view. DocObject activation differs from other kinds of OLE in-place activation. DocObject activation bypasses displaying in-place hatch borders and object adornments (such as sizing handles), ignores object extent functions, and draws scroll bars within the view rectangle as opposed to drawing them outside that rectangle (as in normal in-place activation).  
  
##  \<a name="cdocobjectserver__cdocobjectserver">\</a>  CDocObjectServer::CDocObjectServer  
 Constructs and initializes a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *pOwner*  
 A pointer to the client site document that is the client for the DocObject server.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> interface implemented by the container.  
  
### Remarks  
 When a DocObject is active, the client site OLE interface ( <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>) is what allows the DocObject server to communicate with its client (the container). When a DocObject server is activated, it first checks that the container implements the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> interface. If so, [COleServerDoc::GetDocObjectServer](../vs140/coleserverdoc-class.md#coleserverdoc__getdocobjectserver) is called to see if the container supports DocObjects. By default, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> returns **NULL**. You must override <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to construct a new <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object or a derived object of your own, with pointers to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> container and its <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> interface as arguments to the constructor.  
  
##  \<a name="cdocobjectserver__onactivateview">\</a>  CDocObjectServer::OnActivateView  
 Call this function to display the DocObject view.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns an error or warning value. By default, returns **NOERROR** if successful; otherwise, **E_FAIL**.  
  
### Remarks  
 This function creates an in-place frame window, draws scrollbars within the view, sets up the menus the server shares with its container, adds frame controls, sets the active object, then finally shows the in-place frame window and sets the focus.  
  
##  \<a name="cdocobjectserver__onapplyviewstate">\</a>  CDocObjectServer::OnApplyViewState  
 Override this function to restore the state of the DocObject view.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object from which to serialize the view state.  
  
### Remarks  
 This function is called when the view is being displayed for the first time after its instantiation. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> instructs a view to reinitialize itself according to the data in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object previously saved with [OnSaveViewState](#cdocobjectserver__onsaveviewstate). The view must validate the data in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object because the container does not attempt to interpret the view state data in any way.  
  
 You can use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to store persistent information specific to your view's state. If you override <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to store information, you will want to override <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to read that information and apply it to your view when it is newly activated.  
  
##  \<a name="cdocobjectserver__onsaveviewstate">\</a>  CDocObjectServer::OnSaveViewState  
 Override this function to save extra state information about your DocObject view.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object to which the view state is serialized.  
  
### Remarks  
 Your state might include properties like the view type, zoom factor, insertion and selection point, and so on. The container typically calls this function before deactivating the view. The saved state can later be restored through [OnApplyViewState](#cdocobjectserver__onapplyviewstate).  
  
 You can use <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to store persistent information specific to your view's state. If you override <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to store information, you will want to override <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to read that information and apply it to your view when it is newly activated.  
  
## See Also  
 [Base Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServerItem](../vs140/cdocobjectserveritem-class.md)