---
title: "CJumpList Class"
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
  - "afxadv/CJumpList"
  - "CJumpList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CJumpList class"
ms.assetid: d364d27e-f512-4b12-9872-c2a17c78ab1f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CJumpList Class
A <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is the list of shortcuts revealed when you right click on an icon in the task bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CJumpList::CJumpList](#cjumplist__cjumplist)|Constructs a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
|[CJumpList::~CJumpList](#cjumplist__~cjumplist)|Destroys a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
  
|Name|Description|  
|----------|-----------------|  
|[CJumpList::AbortList](#cjumplist__abortlist)|Aborts a list-building transaction without committing.|  
|[CJumpList::AddDestination](#cjumplist__adddestination)|Overloaded. Adds destination to the list.|  
|[CJumpList::AddKnownCategory](#cjumplist__addknowncategory)|Appends a Known Category to the list.|  
|[CJumpList::AddTask](#cjumplist__addtask)|Overloaded. Adds items to the canonical Tasks category.|  
|[CJumpList::AddTasks](#cjumplist__addtasks)|Adds items to the canonical Tasks category.|  
|[CJumpList::AddTaskSeparator](#cjumplist__addtaskseparator)|Adds a separator between tasks.|  
|[CJumpList::ClearAll](#cjumplist__clearall)|Removes all tasks and destinations that have been added to the current instance of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> so far.|  
|[CJumpList::ClearAllDestinations](#cjumplist__clearalldestinations)|Removes all destinations that have been added to the current instance of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> so far.|  
|[CJumpList::CommitList](#cjumplist__commitlist)|Ends a list-building transaction and commits the reported list to the associated store (the registry in this case.)|  
|[CJumpList::GetDestinationList](#cjumplist__getdestinationlist)|Retrieves an interface pointer to destination list.|  
|[CJumpList::GetMaxSlots](#cjumplist__getmaxslots)|Retrieves the maximum number of items, including category headers that can display in the calling application's destination menu.|  
|[CJumpList::GetRemovedItems](#cjumplist__getremoveditems)|Returns array of items that represent removed destinations.|  
|[CJumpList::InitializeList](#cjumplist__initializelist)|Begins a list-building transaction.|  
|[CJumpList::SetAppID](#cjumplist__setappid)|Sets the Application User Model ID for the list that will be built.|  
  
## Inheritance Hierarchy  
 [CJumpList](../vs140/cjumplist-class.md)  
  
## Requirements  
 **Header:** afxadv.h  
  
##  \<a name="cjumplist___dtorcjumplist">\</a>  CJumpList::~CJumpList  
 Destroys a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cjumplist__abortlist">\</a>  CJumpList::AbortList  
 Aborts a list-building transaction without committing.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Calling this method has the same effect as destroying <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> without calling <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
##  \<a name="cjumplist__adddestination">\</a>  CJumpList::AddDestination  
 Adds destination to the list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies a category name. If the specified category does not exist, it will be created.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies a path to destination file.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies a category name. If the specified category does not exist, it will be created.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Specifies a Shell Item representing the destination being added.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies a Shell Link representing the destination being added.  
  
### Return Value  
  
### Remarks  
 The instance of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> internally accumulates added destinations and then commits them in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
##  \<a name="cjumplist__addknowncategory">\</a>  CJumpList::AddKnownCategory  
 Appends a Known Category to the list.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies a known category type. Can be either <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Return Value  
  
### Remarks  
 Known Categories are the Frequent and Recent categories that we will automatically calculate for every application that utilizes <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (or indirectly uses it as the shell will call it on the application's behalf in some scenarios).  
  
##  \<a name="cjumplist__addtask">\</a>  CJumpList::AddTask  
 Adds items to the canonical Tasks category.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies the target task path.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Specifies command line arguments of the executable specified by strTargetExecutablePath.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Task name that will be displayed in the Destination List.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Location of icon that will be displayed in the Destination List along with the title.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Icon index.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Shell Link that represents a task to be added.  
  
### Return Value  
  
### Remarks  
 The instance of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> accumulates specified tasks and adds them to the Destination List during <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. Task items will appear in a category at the bottom of the application's destination menu. This category takes precedence over all other categories when it is filled in the UI.  
  
##  \<a name="cjumplist__addtasks">\</a>  CJumpList::AddTasks  
 Adds items to the canonical Tasks category.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A collection of tasks to be added.  
  
### Return Value  
  
### Remarks  
 The instance of CJumpList accumulates specified tasks and adds them to the Destination List during <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. Task items will appear in a category at the bottom of the application's destination menu. This category takes precedence over all other categories when it is filled in the UI.  
  
##  \<a name="cjumplist__addtaskseparator">\</a>  CJumpList::AddTaskSeparator  
 Adds a separator between tasks.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if it is successful, 0 if it is not.  
  
##  \<a name="cjumplist__cjumplist">\</a>  CJumpList::CJumpList  
 Constructs a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 If this parameter is FALSE the list is not automatically committed in  destructor.  
  
##  \<a name="cjumplist__clearall">\</a>  CJumpList::ClearAll  
 Removes all tasks and destinations that have been added to the current instance of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> so far.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 This method clears and releases all data and internal interfaces.  
  
##  \<a name="cjumplist__clearalldestinations">\</a>  CJumpList::ClearAllDestinations  
 Removes all destinations that have been added to the current instance of CJumpList so far.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 Call this function if you need to remove all destinations that have been added so far in the current session of destination list building and add other destinations again. If the internal <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> has been initialized, it's left alive.  
  
##  \<a name="cjumplist__commitlist">\</a>  CJumpList::CommitList  
 Ends a list-building transaction and commits the reported list to the associated store (the registry in this case).  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
 The commit is atomic. An error will be returned if the commit fails.  When <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is called, the current list of removed items will be cleaned up. Calling this method resets the object so that it does not have an active list-building transaction. To update the list, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> needs to be called again.  
  
##  \<a name="cjumplist__getdestinationlist">\</a>  CJumpList::GetDestinationList  
 Retrieves an interface pointer to destination list.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
 If the jump list has not been initialized, or has been committed or aborted, the returned value will be <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
##  \<a name="cjumplist__getmaxslots">\</a>  CJumpList::GetMaxSlots  
 Retrieves the maximum number of items, including category headers that can display in the calling application's destination menu.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
 Applications may only report a number of items and category headers combined up to this value. If calls to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> exceed this number, they will return failure.  
  
##  \<a name="cjumplist__getremoveditems">\</a>  CJumpList::GetRemovedItems  
 Returns array of items that represent removed destinations.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
 The removed destinations are retrieved during initialization of jump list. When generating a new destination list, applications are expected to first process the removed destinations list, clearing their tracking data for any item returned by the removed list enumerator. If an application attempts to provide an item that was just removed in the transaction that the current call to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> started, the method call that re-added that item will fail, to ensure that applications are respecting the removed list.  
  
##  \<a name="cjumplist__initializelist">\</a>  CJumpList::InitializeList  
 Begins a list-building transaction.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
 You don't need to call this method explicitly unless you wish to retrieve a pointer to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> using <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, the number of available slots using <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, or list of removed items using <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
##  \<a name="cjumplist__setappid">\</a>  CJumpList::SetAppID  
 Sets the Application User Model ID for the list that will be built.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 A string that specifies the Application User Model ID.  
  
## See Also  
 [Reference (MFC)](../vs140/mfc-classes.md)