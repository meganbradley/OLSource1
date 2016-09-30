---
title: "COleDBRecordView Class"
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
  - "COleDBRecordView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC, OLE DB"
  - "COleDBRecordView class"
ms.assetid: 98612427-c4c9-4760-b7e1-85b17448add9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDBRecordView Class
A view that displays database records in controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleDBRecordView::COleDBRecordView](#coledbrecordview__coledbrecordview)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDBRecordView::OnGetRowset](#coledbrecordview__ongetrowset)|Returns a standard <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value.|  
|[COleDBRecordView::OnMove](#coledbrecordview__onmove)|Updates the current record (if dirty) on the data source and then moves to the specified record (next, previous, first, or last).|  
  
## Remarks  
 The view is a form view directly connected to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. The view is created from a dialog template resource and displays the fields of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object in the dialog template's controls. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object uses dialog data exchange (DDX), and the navigational functionality built into <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, to automate the movement of data between the controls on the form and the fields of the rowset. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> also supplies a default implementation for moving to the first, next, previous, or last record and an interface for updating the record currently on view.  
  
 You can use DDX functions with **COleDbRecordView** to get data directly from the database recordset and display it in a dialog control. You should use the **DDX_\*** methods (such as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>), not the **DDX_Field\*** functions (such as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) with **COleDbRecordView**. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> will not work with **COleDbRecordView** because <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> takes an additional argument of type **CRecordset\*** (for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) or **CDaoRecordset\*** (for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>).  
  
> [!NOTE]
>  If you are working with the Data Access Objects (DAO) classes rather than the OLE DB Consumer Template classes, use class [CDaoRecordView](../vs140/cdaorecordview-class.md) instead. For more information, see the article [Overview: Database Programming](../vs140/data-access-programming--mfc-atl-.md).  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keeps track of the user's position in the rowset so that the record view can update the user interface. When the user moves to either end of the rowset, the record view disables user interface objects â€” such as menu items or toolbar buttons â€” for moving further in the same direction.  
  
 For more information about rowset classes, see the [Using OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md) article.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 [CScrollView](../vs140/cscrollview-class.md)  
  
 [CFormView](../vs140/cformview-class.md)  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxoledb.h  
  
##  \<a name="coledbrecordview__coledbrecordview">\</a>  COleDBRecordView::COleDBRecordView  
 Constructs a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Contains a null-terminated string that is the name of a dialog-template resource.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Contains the ID number of a dialog-template resource.  
  
### Remarks  
 When you create an object of a type derived from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, invoke one of the constructors to create the view object and identify the dialog resource on which the view is based. You can identify the resource either by name (pass a string as the argument to the constructor) or by its ID (pass an unsigned integer as the argument).  
  
> [!NOTE]
>  Your derived class                             *must* supply its own constructor. In the constructor, invoke the constructor, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, with the resource name or ID as an argument.  
  
##  \<a name="coledbrecordview__ongetrowset">\</a>  COleDBRecordView::OnGetRowset  
 Returns a handle for the **CRowset<>** object associated with the record view.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A standard <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> value.  
  
### Remarks  
 You must override this member function to construct or obtain a rowset object and return a handle to it. If you declare your record view class with ClassWizard, the wizard writes a default override for you. ClassWizard's default implementation returns the rowset handle stored in the record view if one exists. If not, it constructs a rowset object of the type you specified with ClassWizard and calls its **Open** member function to open the table or run the query, and then returns a handle to the object.  
  
> [!NOTE]
>  Previous to MFC 7.0, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> returned a pointer to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. If you have code that calls <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, you need to change the return type to the templatized class **CRowset<>**.  
  
### Example  
 [!code[NVC_MFCDatabase#38](../vs140/codesnippet/CPP/coledbrecordview-class_1.cpp)]  
  
 For more information and examples, see the article [Record Views: Using a Record View](../vs140/using-a-record-view---mfc-data-access-.md).  
  
##  \<a name="coledbrecordview__onmove">\</a>  COleDBRecordView::OnMove  
 Moves to a different record in the rowset and display its fields in the controls of the record view.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 One of the following standard command ID values:  
  
-   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>Â Â Â Move to the first record in the recordset.  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>Â Â Â Move to the last record in the recordset.  
  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>Â Â Â Move to the next record in the recordset.  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>Â Â Â Move to the previous record in the recordset.  
  
### Return Value  
 Nonzero if the move was successful; otherwise 0 if the move request was denied.  
  
### Remarks  
 The default implementation calls the appropriate **Move** member function of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object associated with the record view.  
  
 By default, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> updates the current record on the data source if the user has changed it in the record view.  
  
 The Application Wizard creates a menu resource with First Record, Last Record, Next Record, and Previous Record menu items. If you select the Dockable Toolbar option, The Application Wizard also creates a toolbar with buttons corresponding to these commands.  
  
 If you move past the last record in the recordset, the record view continues to display the last record. If you move backward past the first record, the record view continues to display the first record.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)