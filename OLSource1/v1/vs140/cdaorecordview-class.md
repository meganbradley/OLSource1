---
title: "CDaoRecordView Class"
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
  - "CDaoRecordView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordView class"
  - "data-bound controls [C++], DAO controls"
  - "data binding [C++], DAO views"
  - "bound controls [C++], displaying database data"
  - "application wizards [C++], creating record views"
  - "controls [MFC], data binding"
ms.assetid: 5aa7d0e2-bd05-413e-b216-80c404ce18ac
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordView Class
A view that displays database records in controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoRecordView::CDaoRecordView](#cdaorecordview__cdaorecordview)|Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDaoRecordView::IsOnFirstRecord](#cdaorecordview__isonfirstrecord)|Returns nonzero if the current record is the first record in the associated recordset.|  
|[CDaoRecordView::IsOnLastRecord](#cdaorecordview__isonlastrecord)|Returns nonzero if the current record is the last record in the associated recordset.|  
|[CDaoRecordView::OnGetRecordset](#cdaorecordview__ongetrecordset)|Returns a pointer to an object of a class derived from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. ClassWizard overrides this function for you and creates the recordset if necessary.|  
|[CDaoRecordView::OnMove](#cdaorecordview__onmove)|If the current record has changed, updates it on the data source, then moves to the specified record (next, previous, first, or last).|  
  
## Remarks  
 The view is a form view directly connected to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. The view is created from a dialog template resource and displays the fields of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object in the dialog template's controls. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object uses dialog data exchange (DDX) and DAO record field exchange (DFX) to automate the movement of data between the controls on the form and the fields of the recordset. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> also supplies a default implementation for moving to the first, next, previous, or last record and an interface for updating the record currently in view.  
  
> [!NOTE]
>  The DAO database classes are distinct from the MFC database classes based on Open Database Connectivity (ODBC). All DAO database class names have the "CDao" prefix. You can still access ODBC data sources with the DAO classes; the DAO classes generally offer superior capabilities because they use the Microsoft Jet database engine.  
  
 The most common way to create your record view is with the Application Wizard. The Application Wizard creates both the record view class and its associated recordset class as part of your skeleton starter application.  
  
 If you simply need a single form, the Application Wizard approach is easier. ClassWizard lets you decide to use a record view later in the development process. If you don't create the record view class with the Application Wizard, you can create it later with ClassWizard. Using ClassWizard to create a record view and a recordset separately and then connect them is the most flexible approach because it gives you more control in naming the recordset class and its .H/.CPP files. This approach also lets you have multiple record views on the same recordset class.  
  
 To make it easy for end-users to move from record to record in the record view, the Application Wizard creates menu (and optionally toolbar) resources for moving to the first, next, previous, or last record. If you create a record view class with ClassWizard, you need to create these resources yourself with the menu and bitmap editors.  
  
 For information about the default implementation for moving from record to record, see <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and the article [Using a Record View](../vs140/using-a-record-view---mfc-data-access-.md), which applies to both <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keeps track of the user's position in the recordset so that the record view can update the user interface. When the user moves to either end of the recordset, the record view disables user interface objects — such as menu items or toolbar buttons — for moving further in the same direction.  
  
 For more information about declaring and using your record view and recordset classes, see "Designing and Creating a Record View" in the article [Record Views](../vs140/record-views---mfc-data-access-.md). For more information about how record views work and how to use them, see the article [Using a Record View](../vs140/using-a-record-view---mfc-data-access-.md). All the articles mentioned above apply to both <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 [CScrollView](../vs140/cscrollview-class.md)  
  
 [CFormView](../vs140/cformview-class.md)  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdao.h  
  
##  \<a name="cdaorecordview__cdaorecordview">\</a>  CDaoRecordView::CDaoRecordView  
 When you create an object of a type derived from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, call either form of the constructor to initialize the view object and identify the dialog resource on which the view is based.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Contains a null-terminated string that is the name of a dialog template resource.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Contains the ID number of a dialog template resource.  
  
### Remarks  
 You can either identify the resource by name (pass a string as the argument to the constructor) or by its ID (pass an unsigned integer as the argument). Using a resource ID is recommended.  
  
> [!NOTE]
>  Your derived class must supply its own constructor. In the constructor of your derived class, call the constructor <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> with the resource name or ID as an argument.  
  
 **CDaoRecordView::OnInitialUpdate** calls <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, which calls <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. This initial call to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> connects <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> controls (indirectly) to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> field data members created by ClassWizard. These data members cannot be used until after you call the base class **CFormView::OnInitialUpdate** member function.  
  
> [!NOTE]
>  If you use ClassWizard, the wizard defines an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> value <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in the class declaration and uses it in the member initialization list for the constructor.  
  
 [!code[NVC_MFCDatabase#35](../vs140/codesnippet/CPP/cdaorecordview-class_1.cpp)]  
  
##  \<a name="cdaorecordview__isonfirstrecord">\</a>  CDaoRecordView::IsOnFirstRecord  
 Call this member function to determine whether the current record is the first record in the recordset object associated with this record view.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the current record is the first record in the recordset; otherwise 0.  
  
### Remarks  
 This function is useful for writing your own implementations of the default command update handlers written by ClassWizard.  
  
 If the user moves to the first record, the framework disables any user interface objects (for example, menu items or toolbar buttons) you have for moving to the first or the previous record.  
  
##  \<a name="cdaorecordview__isonlastrecord">\</a>  CDaoRecordView::IsOnLastRecord  
 Call this member function to determine whether the current record is the last record in the recordset object associated with this record view.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the current record is the last record in the recordset; otherwise 0.  
  
### Remarks  
 This function is useful for writing your own implementations of the default command update handlers that ClassWizard writes to support a user interface for moving from record to record.  
  
> [!CAUTION]
>  The result of this function is reliable except that the view may not be able to detect the end of the recordset until the user has moved past it. The user might have to move beyond the last record before the record view can tell that it must disable any user interface objects for moving to the next or last record. If the user moves past the last record and then moves back to the last record (or before it), the record view can track the user's position in the recordset and disable user interface objects correctly.  
  
##  \<a name="cdaorecordview__ongetrecordset">\</a>  CDaoRecordView::OnGetRecordset  
 Returns a pointer to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>-derived object associated with the record view.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>-derived object if the object was successfully created; otherwise a **NULL** pointer.  
  
### Remarks  
 You must override this member function to construct or obtain a recordset object and return a pointer to it. If you declare your record view class with ClassWizard, the wizard writes a default override for you. ClassWizard's default implementation returns the recordset pointer stored in the record view if one exists. If not, it constructs a recordset object of the type you specified with ClassWizard and calls its **Open** member function to open the table or run the query, and then returns a pointer to the object.  
  
 For more information and examples, see the article [Record Views: Using a Record View](../vs140/using-a-record-view---mfc-data-access-.md).  
  
##  \<a name="cdaorecordview__onmove">\</a>  CDaoRecordView::OnMove  
 Call this member function to move to a different record in the recordset and display its fields in the controls of the record view.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 One of the following standard command ID values:  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> Move to the first record in the recordset.  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> Move to the last record in the recordset.  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> Move to the next record in the recordset.  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> Move to the previous record in the recordset.  
  
### Return Value  
 Nonzero if the move was successful; otherwise 0 if the move request was denied.  
  
### Remarks  
 The default implementation calls the appropriate Move member function of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object associated with the record view.  
  
 By default, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> updates the current record on the data source if the user has changed it in the record view.  
  
 The Application Wizard creates a menu resource with First Record, Last Record, Next Record, and Previous Record menu items. If you select the Initial Toolbar option, the Application Wizard also creates a toolbar with buttons corresponding to these commands.  
  
 If you move past the last record in the recordset, the record view continues to display the last record. If you move backward past the first record, the record view continues to display the first record.  
  
> [!CAUTION]
>  Calling <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> throws an exception if the recordset has no records. Call the appropriate user interface update handler function — **OnUpdateRecordFirst**, **OnUpdateRecordLast**, **OnUpdateRecordNext**, or **OnUpdateRecordPrev** — before the corresponding move operation to determine whether the recordset has any records.  
  
## See Also  
 [Base Class](../vs140/cformview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset](../vs140/cdaorecordset-class.md)   
 [CDaoTableDef](../vs140/cdaotabledef-class.md)   
 [CDaoQueryDef](../vs140/cdaoquerydef-class.md)   
 [CDaoDatabase](../vs140/cdaodatabase-class.md)   
 [CDaoWorkspace](../vs140/cdaoworkspace-class.md)   
 [CFormView](../vs140/cformview-class.md)