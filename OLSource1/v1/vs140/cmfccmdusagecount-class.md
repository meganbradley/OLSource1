---
title: "CMFCCmdUsageCount Class"
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
  - "CMFCCmdUsageCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCCmdUsageCount class"
ms.assetid: 9c33b783-37c0-43ea-9f31-3c75e246c841
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCmdUsageCount Class
Tracks the usage count of Windows messages, such as when the user selects an item from a menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCCmdUsageCount::AddCmd](#cmfccmdusagecount__addcmd)|Increments by one the counter that is associated with the given command.|  
|[CMFCCmdUsageCount::GetCount](#cmfccmdusagecount__getcount)|Retrieves the usage count that is associated with the given command ID.|  
|[CMFCCmdUsageCount::HasEnoughInformation](#cmfccmdusagecount__hasenoughinformation)|Determines whether this object has collected the minimum amount of tracking data.|  
|[CMFCCmdUsageCount::IsFreqeuntlyUsedCmd](#cmfccmdusagecount__isfreqeuntlyusedcmd)|Determines whether the given command is frequently used.|  
|[CMFCCmdUsageCount::Reset](#cmfccmdusagecount__reset)|Clears the usage count of all commands.|  
|[CMFCCmdUsageCount::Serialize](#cmfccmdusagecount__serialize)|Reads this object from an archive or writes it to an archive. (Overrides [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize).)|  
|[CMFCCmdUsageCount::SetOptions](#cmfccmdusagecount__setoptions)|Sets the values of shared <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class data members.|  
  
### Data Members  
  
|||  
|-|-|  
|Name|Description|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object that maps commands to their usage counts.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The minimum usage percentage for a command to be frequently used.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The start counter that is used to determine whether this object has collected the minimum amount of tracking data.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The count of all tracked commands.|  
  
### Remarks  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class maps each numeric Windows message identifier to a 32-bit unsigned integer counter. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> uses this class to display frequently-used toolbar items. For more information about <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, see [CMFCToolBar Class](../vs140/cmfctoolbar-class.md).  
  
 You can persist <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class data between runs of your program. Use the [CMFCCmdUsageCount::Serialize](#cmfccmdusagecount__serialize) method to serialize class member data and the [CMFCCmdUsageCount::SetOptions](#cmfccmdusagecount__setoptions) method to set shared member data.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCCmdUsageCount](../vs140/cmfccmdusagecount-class.md)  
  
## Requirements  
 **Header:** afxcmdusagecount.h  
  
##  \<a name="cmfccmdusagecount__addcmd">\</a>  CMFCCmdUsageCount::AddCmd  
 Increments by one the counter that is associated with the given command.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Specifies the command counter to increment.|  
  
### Remarks  
 This method adds a new entry to the map structure of command counts, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, if the entry does not already exist.  
  
 This method does nothing in the following cases:  
  
-   The toolbar framework is in customization mode (the [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__iscustomizemode) method returns a nonzero value).  
  
-   The command refers to a submenu or menu separator ( <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> equals 0 or -1).  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> refers to a standard command (the global <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function returns a nonzero value).  
  
##  \<a name="cmfccmdusagecount__getcount">\</a>  CMFCCmdUsageCount::GetCount  
 Retrieves the usage count that is associated with the given command ID.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The ID of the command counter to retrieve.|  
  
### Return Value  
 The usage count that is associated with the given command ID.  
  
##  \<a name="cmfccmdusagecount__hasenoughinformation">\</a>  CMFCCmdUsageCount::HasEnoughInformation  
 Determines whether this object has received the minimum amount of tracking data.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if this object has received the minimum amount of tracking data; otherwise 0.  
  
### Remarks  
 This method returns a nonzero value if the total count, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, of all tracked commands is equal to or larger than the initial count, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. By default, the framework sets the initial count 0. You can override this value by using the [CMFCCmdUsageCount::SetOptions](#cmfccmdusagecount__setoptions) method.  
  
 This method is used by [CMFCMenuBar::IsShowAllCommands](../vs140/cmfcmenubar-class.md#cmfcmenubar__isshowallcommands) to determine whether to show all available menu commands.  
  
##  \<a name="cmfccmdusagecount__isfreqeuntlyusedcmd">\</a>  CMFCCmdUsageCount::IsFreqeuntlyUsedCmd  
 Determines whether the given command is frequently used.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Specifies the command to check.|  
  
### Return Value  
 Nonzero if the command is frequently used; otherwise 0.  
  
### Remarks  
 This method returns 0 if the total command usage, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, is 0. Otherwise, this method returns nonzero if the percentage of which the specified command is used is larger than the minimum percentage, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. By default, the framework sets the minimum percentage to 5. You can override this value by using the [CMFCCmdUsageCount::SetOptions](#cmfccmdusagecount__setoptions) method. If the minimum percentage is 0, this method returns nonzero if the specified command count is larger than 0.  
  
 [CMFCToolBar::IsCommandRarelyUsed](../vs140/cmfctoolbar-class.md#cmfctoolbar__iscommandrarelyused) uses this method to determine whether a command is rarely used.  
  
##  \<a name="cmfccmdusagecount__reset">\</a>  CMFCCmdUsageCount::Reset  
 Clears the usage count of all commands.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Call this method to clear all entries from the map structure of command counts, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and to reset the total command usage, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, counter to 0.  
  
##  \<a name="cmfccmdusagecount__serialize">\</a>  CMFCCmdUsageCount::Serialize  
 Reads this object from an archive, or writes it to an archive.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|A <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object to serialize from or to.|  
  
### Remarks  
 This method serializes the map structure of command counts, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and the total command usage, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, counter from or to the specified archive.  
  
 For serialization examples, see [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md).  
  
##  \<a name="cmfccmdusagecount__setoptions">\</a>  CMFCCmdUsageCount::SetOptions  
 Sets the values of shared <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> class data members.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|The new initial count of all tracked commands.|  
|[in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|The new minimum usage percentage.|  
  
### Return Value  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if the method succeeds, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> parameter is larger than or equal to 100.  
  
### Remarks  
 This method sets the shared <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> class data members <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, respectively. <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is used by the [CMFCCmdUsageCount::HasEnoughInformation](#cmfccmdusagecount__hasenoughinformation) method to determine whether this object has collected the minimum amount of tracking data. <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is used by the [CMFCCmdUsageCount::IsFreqeuntlyUsedCmd](#cmfccmdusagecount__isfreqeuntlyusedcmd) method to determine whether a given command is frequently used.  
  
 In Debug builds this method generates an assertion failure if the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> parameter is larger than or equal to 100.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)