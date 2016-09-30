---
title: "CDataRecoveryHandler Class"
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
  - "CDataRecoveryHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDataRecoveryHandler class"
ms.assetid: 7794802c-e583-4eba-90b9-2fed1a161f9c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler Class
The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> autosaves documents and restores them if an application unexpectedly exits.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Constructors  
  
|||  
|-|-|  
|[CDataRecoveryHandler::CDataRecoveryHandler](#cdatarecoveryhandler__cdatarecoveryhandler)|Constructs a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.|  
  
### Methods  
  
|||  
|-|-|  
|[CDataRecoveryHandler::AutosaveAllDocumentInfo](#cdatarecoveryhandler__autosavealldocumentinfo)|Autosaves each file registered with the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class.|  
|[CDataRecoveryHandler::AutosaveDocumentInfo](#cdatarecoveryhandler__autosavedocumentinfo)|Autosaves the specified document.|  
|[CDataRecoveryHandler::CreateDocumentInfo](#cdatarecoveryhandler__createdocumentinfo)|Adds a document to the list of open documents.|  
|[CDataRecoveryHandler::DeleteAllAutosavedFiles](#cdatarecoveryhandler__deleteallautosavedfiles)|Deletes all the current autosaved files.|  
|[CDataRecoveryHandler::DeleteAutosavedFile](#cdatarecoveryhandler__deleteautosavedfile)|Deletes the specified autosaved file.|  
|[CDataRecoveryHandler::GenerateAutosaveFileName](#cdatarecoveryhandler__generateautosavefilename)|Generates the name for an autosave file associated with the supplied document file name.|  
|[CDataRecoveryHandler::GetAutosaveInterval](#cdatarecoveryhandler__getautosaveinterval)|Returns the interval between autosave tries.|  
|[CDataRecoveryHandler::GetAutosavePath](#cdatarecoveryhandler__getautosavepath)|Returns the path of the autosaved files.|  
|[CDataRecoveryHandler::GetDocumentListName](#cdatarecoveryhandler__getdocumentlistname)|Retrieves the document name from a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
|[CDataRecoveryHandler::GetNormalDocumentTitle](#cdatarecoveryhandler__getnormaldocumenttitle)|Retrieves the normal title for the specified document.|  
|[CDataRecoveryHandler::GetRecoveredDocumentTitle](#cdatarecoveryhandler__getrecovereddocumenttitle)|Creates and returns the title for the recovered document.|  
|[CDataRecoveryHandler::GetRestartIdentifier](#cdatarecoveryhandler__getrestartidentifier)|Retrieves the unique restart identifier for the application.|  
|[CDataRecoveryHandler::GetSaveDocumentInfoOnIdle](#cdatarecoveryhandler__getsavedocumentinfoonidle)|Indicates whether the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> performs an autosave on the current idle loop.|  
|[CDataRecoveryHandler::GetShutdownByRestartManager](#cdatarecoveryhandler__getshutdownbyrestartmanager)|Indicates whether the restart manager caused the application to exit.|  
|[CDataRecoveryHandler::Initialize](#cdatarecoveryhandler__initialize)|Initializes the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
|[CDataRecoveryHandler::QueryRestoreAutosavedDocuments](#cdatarecoveryhandler__queryrestoreautosaveddocuments)|Displays a dialog box to the user for each document that the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> autosaved. The dialog box determines whether the user wants to restore the autosaved document.|  
|[CDataRecoveryHandler::ReadOpenDocumentList](#cdatarecoveryhandler__readopendocumentlist)|Loads the open document list from the registry.|  
|[CDataRecoveryHandler::RemoveDocumentInfo](#cdatarecoveryhandler__removedocumentinfo)|Removes the supplied document from the open document list.|  
|[CDataRecoveryHandler::ReopenPreviousDocuments](#cdatarecoveryhandler__reopenpreviousdocuments)|Opens the previously open documents.|  
|[CDataRecoveryHandler::RestoreAutosavedDocuments](#cdatarecoveryhandler__restoreautosaveddocuments)|Restores the autosaved documents based on user input.|  
|[CDataRecoveryHandler::SaveOpenDocumentList](#cdatarecoveryhandler__saveopendocumentlist)|Saves the current list of open documents to the Windows registry.|  
|[CDataRecoveryHandler::SetAutosaveInterval](#cdatarecoveryhandler__setautosaveinterval)|Sets the time between autosave cycles in milliseconds.|  
|[CDataRecoveryHandler::SetAutosavePath](#cdatarecoveryhandler__setautosavepath)|Sets the directory where autosaved files are stored.|  
|[CDataRecoveryHandler::SetRestartIdentifier](#cdatarecoveryhandler__setrestartidentifier)|Sets the unique restart identifier for this instance of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.|  
|[CDataRecoveryHandler::SetSaveDocumentInfoOnIdle](#cdatarecoveryhandler__setsavedocumentinfoonidle)|Sets whether the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> saves the open document information to the Windows registry during the current idle cycle.|  
|[CDataRecoveryHandler::SetShutdownByRestartManager](#cdatarecoveryhandler__setshutdownbyrestartmanager)|Sets whether the previous exit of the application was caused by the restart manager.|  
|[CDataRecoveryHandler::UpdateDocumentInfo](#cdatarecoveryhandler__updatedocumentinfo)|Updates the information for a document because the user saved it.|  
  
### Data Members  
  
|||  
|-|-|  
|m_bRestoringPreviousOpenDocs|Indicates whether the data recovery handler reopens previously open documents.|  
|m_bSaveDocumentInfoOnIdle|Indicates whether the data recovery handler autosaves documents on the next idle loop.|  
|m_bShutdownByRestartManager|Indicates whether the restart manager causes the application to exit.|  
|m_dwRestartManagerSupportFlags|Flags that indicate what support the restart manager provides for the application.|  
|m_lstAutosavesToDelete|A list of autosaved files that were not deleted when the original documents were closed. When the application exits, the restart manager retries deleting the files.|  
|m_mapDocNameToAutosaveName|A map of the document names to the autosaved file names.|  
|m_mapDocNameToDocumentPtr|A map of the document names to the [CDocument](../vs140/cdocument-class.md) pointers.|  
|m_mapDocNameToRestoreBool|A map of the document names to a Boolean parameter that indicates whether to restore the autosaved document.|  
|m_mapDocumentPtrToDocName|A map of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> pointers to the document names.|  
|m_mapDocumentPtrToDocTitle|A map of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> pointers to the document titles. These titles are used for saving files.|  
|m_nAutosaveInterval|Time in milliseconds between autosaves.|  
|m_nTimerID|The identifier for the autosave timer.|  
|m_strAutosavePath|The location where the autosaved documents are stored.|  
|m_strRestartIdentifier|The string representation of a GUID for the restart manager.|  
  
## Remarks  
 The restart manager uses the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> class to keep track of all open documents and to autosave them as necessary. To enable autosave, use the [CDataRecoveryHandler::SetSaveDocumentInfoOnIdle](#cdatarecoveryhandler__setsavedocumentinfoonidle) method. This method directs the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to perform an autosave on the next idle loop. The restart manager calls <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> when the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> should perform an autosave.  
  
 All of the methods of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> class are virtual. Override the methods in this class to create your own custom data recovery handler. Unless you create your own data recovery handler or restart manager, do not instantiate a CDataRecoveryHandler. The [CWinApp Class](../vs140/cwinapp-class.md) creates a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object as it is required.  
  
 Before you can use a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object, you must call [CDataRecoveryHandler::Initialize](#cdatarecoveryhandler__initialize).  
  
 Because the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> class is closely connected to the restart manager, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> depends on the global parameter <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. This parameter determines what permissions the restart manager has and how it interacts with your application. To incorporate the restart manager into an existing application, you have to assign <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> the appropriate value in the constructor of your main application. For more information about how to use the restart manager, see [How to: Add Restart Manager Support](../vs140/how-to--add-restart-manager-support.md).  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
##  \<a name="cdatarecoveryhandler__autosavealldocumentinfo">\</a>  CDataRecoveryHandler::AutosaveAllDocumentInfo  
 Autosaves each file registered with the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> saved all the documents; <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> if any document was not saved.  
  
### Remarks  
 This method returns <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> if there are no documents that must be saved. It also returns <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> without saving any documents if retrieving the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> for the application generates an error.  
  
 To use this method, either <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cdatarecoveryhandler__autosavedocumentinfo">\</a>  CDataRecoveryHandler::AutosaveDocumentInfo  
 Autosaves the specified document.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|A pointer to the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to save.|  
|[in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder> indicates that the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> considers <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> to be modified; <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> indicates that the framework considers <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> to be unmodified. See the Remarks section for more information about the effect of this flag.|  
  
### Return Value  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> if the appropriate flags are set and <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is a valid <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Each <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object has a flag that indicates if it has changed since the last save. Use [CDocument::IsModified](../vs140/cdocument-class.md#cdocument__ismodified) to determine the state of this flag. If a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> has not changed since the last save, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> deletes any autosaved files for that document. If a document has changed since the last save, closing it prompts the user to save the document before closing.  
  
> [!NOTE]
>  Using <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> to change the state of the document to unmodified may cause the user to lose unsaved data. If the framework considers a document unmodified, closing it does not prompt the user to save.  
  
 This method throws an exception with the [ASSERT (MFC)](../vs140/assert--mfc-.md) macro if <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> is not a valid <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object.  
  
 To use this method, either <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cdatarecoveryhandler__cdatarecoveryhandler">\</a>  CDataRecoveryHandler::CDataRecoveryHandler  
 Constructs a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|Indicates which options of the restart manager are supported.|  
|[in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|The time between autosaves. This parameter is in milliseconds.|  
  
### Remarks  
 The MFC framework automatically creates a <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object for your application when you use the **New Project** wizard. Unless you are customizing the data recovery behavior or the restart manager, you should not create a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object.  
  
 For more information about the support flags, see [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md).  
  
##  \<a name="cdatarecoveryhandler__createdocumentinfo">\</a>  CDataRecoveryHandler::CreateDocumentInfo  
 Adds a document to the list of open documents.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|A pointer to a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>. This method creates the document information for this <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.|  
  
### Return Value  
 The default implementation returns <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method checks if <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is already in the list of documents before it adds the document. If <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> is already in the list, this method deletes the autosaved file associated with <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
 To use this method, either <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cdatarecoveryhandler__deleteallautosavedfiles">\</a>  CDataRecoveryHandler::DeleteAllAutosavedFiles  
 Deletes all the current autosaved files.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The default implementation always returns <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
##  \<a name="cdatarecoveryhandler__deleteautosavedfile">\</a>  CDataRecoveryHandler::DeleteAutosavedFile  
 Deletes the specified autosaved file.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|A string that contains the autosaved file name.|  
  
### Return Value  
 The default implementation always return <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
### Remarks  
 If this method cannot delete the autosaved file, it saves the name of the file in a list. The destructor for the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> tries to delete each autosaved file specified in that list.  
  
##  \<a name="cdatarecoveryhandler__generateautosavefilename">\</a>  CDataRecoveryHandler::GenerateAutosaveFileName  
 Generates the name for an autosave file associated with the supplied document file name.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 A string that contains the document name. <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> uses this document name to generate a corresponding autosave file name.  
  
### Return Value  
 The autosave file name generated from <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
### Remarks  
 Each document name has a one-to-one mapping with an autosave file name.  
  
##  \<a name="cdatarecoveryhandler__getautosaveinterval">\</a>  CDataRecoveryHandler::GetAutosaveInterval  
 Returns the interval between autosave tries.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The number of milliseconds between autosave tries.  
  
##  \<a name="cdatarecoveryhandler__getautosavepath">\</a>  CDataRecoveryHandler::GetAutosavePath  
 Returns the path of the autosaved files.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The location where the autosaved documents are stored.  
  
##  \<a name="cdatarecoveryhandler__getdocumentlistname">\</a>  CDataRecoveryHandler::GetDocumentListName  
 Retrieves the document name from a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>|A pointer to a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> retrieves the document name from this <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.|  
  
### Return Value  
 The document name from <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> uses the document name as the key in <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>. These parameter enable the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> to monitor <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> objects, the autosave file name, and the autosave settings.  
  
##  \<a name="cdatarecoveryhandler__getnormaldocumenttitle">\</a>  CDataRecoveryHandler::GetNormalDocumentTitle  
 Retrieves the normal title for the specified document.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>|A pointer to a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.|  
  
### Return Value  
 The normal title for the specified document.  
  
### Remarks  
 The normal title of a document is usually the file name of the document without the path. This is the title in the **File name** field of the **Save As** dialog box.  
  
##  \<a name="cdatarecoveryhandler__getrecovereddocumenttitle">\</a>  CDataRecoveryHandler::GetRecoveredDocumentTitle  
 Creates and returns the title for the recovered document.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The normal title for the document.  
  
### Return Value  
 The recovered document title.  
  
### Remarks  
 By default, the recovered title of a document is the normal title with **[recovered]** appended to it. The recovered title is displayed to the user when the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> queries the user to restore autosaved documents.  
  
##  \<a name="cdatarecoveryhandler__getrestartidentifier">\</a>  CDataRecoveryHandler::GetRestartIdentifier  
 Retrieves the unique restart identifier for the application.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The unique restart identifier.  
  
### Remarks  
 The restart identifier is unique for each execution of the application.  
  
 The <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> stores information in the registry about the currently open documents. When the restart manager exits an application and restarts it, it supplies the restart identifier to the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> uses the restart identifier to retrieve the list of previously open documents. This enables the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> to try to find and restore autosaved files.  
  
##  \<a name="cdatarecoveryhandler__getsavedocumentinfoonidle">\</a>  CDataRecoveryHandler::GetSaveDocumentInfoOnIdle  
 Indicates whether the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> performs an autosave on the current idle loop.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> indicates the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> autosaves on the current idle loop; <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> indicates it does not.  
  
##  \<a name="cdatarecoveryhandler__getshutdownbyrestartmanager">\</a>  CDataRecoveryHandler::GetShutdownByRestartManager  
 Indicates whether the restart manager caused the application to exit.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> indicates the restart manager caused the application to exit; <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> indicates it did not.  
  
##  \<a name="cdatarecoveryhandler__initialize">\</a>  CDataRecoveryHandler::Initialize  
 Initializes the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> if the initialization is successful; otherwise <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
### Remarks  
 The initialization process loads the path for storing autosave files from the registry. If the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> method cannot find this directory or if the path is <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> fails and returns <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
 Use [CDataRecoveryHandler::SetAutosavePath](#cdatarecoveryhandler__setautosavepath) to change the autosave path after your application initializes the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> method also starts a timer to monitor when the next autosave occurs. Use [CDataRecoveryHandler::SetAutosaveInterval](#cdatarecoveryhandler__setautosaveinterval) to change the autosave interval after your application initializes the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
##  \<a name="cdatarecoveryhandler__queryrestoreautosaveddocuments">\</a>  CDataRecoveryHandler::QueryRestoreAutosavedDocuments  
 Displays a dialog box to the user for each document that the <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> autosaved. The dialog box determines whether the user wants to restore the autosaved document.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 If your application is Unicode, this method displays a [CTaskDialog](../vs140/ctaskdialog-class.md) to the user. Otherwise, the framework uses [AfxMessageBox](../vs140/afxmessagebox.md) to query the user.  
  
 After <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> gathers all the responses from the user, it stores the information in the member variable <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>. This method does not restore the autosaved documents.  
  
##  \<a name="cdatarecoveryhandler__readopendocumentlist">\</a>  CDataRecoveryHandler::ReadOpenDocumentList  
 Loads the open document list from the registry.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> indicates that <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> loaded the information for at least one document from the registry; <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> indicates no document information was loaded.  
  
### Remarks  
 This function loads the open document information from the registry and stores it in the member variable <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.  
  
 After <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> loads all the data, it deletes the document information from the registry.  
  
##  \<a name="cdatarecoveryhandler__removedocumentinfo">\</a>  CDataRecoveryHandler::RemoveDocumentInfo  
 Removes the supplied document from the open document list.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>|A pointer to the document to remove.|  
  
### Return Value  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> was removed from the list; <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> if an error occurred.  
  
### Remarks  
 When the user closes a document, the framework uses this method to remove it from the list of open documents.  
  
 If <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> cannot find <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> in the list of open documents, it does nothing and returns <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
 To use this method, <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cdatarecoveryhandler__reopenpreviousdocuments">\</a>  CDataRecoveryHandler::ReopenPreviousDocuments  
 Opens the previously open documents.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> if at least one document was opened; otherwise <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method opens the most recent save of the previously open documents. If a document was not saved or autosaved, <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> opens a blank document based on the template for that file type.  
  
 To use this method, <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> parameter. If this parameter is not set, <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> does nothing and returns <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.  
  
 If there are no documents stored in the list of previously open documents, <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> does nothing and returns <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
##  \<a name="cdatarecoveryhandler__restoreautosaveddocuments">\</a>  CDataRecoveryHandler::RestoreAutosavedDocuments  
 Restores the autosaved documents based on user input.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> if this method successfully restores the documents.  
  
### Remarks  
 This method calls [CDataRecoveryHandler::QueryRestoreAutosavedDocuments](#cdatarecoveryhandler__queryrestoreautosaveddocuments) to determine which documents the user wants to restore. If a user decides not to restore an autosaved document, <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> deletes the autosave file. Otherwise, <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> replaces the open document with the autosaved version.  
  
 To use this method, either <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cdatarecoveryhandler__saveopendocumentlist">\</a>  CDataRecoveryHandler::SaveOpenDocumentList  
 Saves the current list of open documents to the Windows registry.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> if there are no open documents to save or if they were saved successfully. <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> if there are documents to save to the registry, but they were not saved because an error occurred.  
  
### Remarks  
 The restart manager calls <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> when the application exits unexpectedly or when it exits for an upgrade. When the application restarts, it uses [CDataRecoveryHandler::ReadOpenDocumentList](#cdatarecoveryhandler__readopendocumentlist) to retrieve the list of open documents.  
  
 This method saves only the list of open documents. The method [CDataRecoveryHandler::AutosaveDocumentInfo](#cdatarecoveryhandler__autosavedocumentinfo) is responsible for saving the documents themselves.  
  
##  \<a name="cdatarecoveryhandler__setautosaveinterval">\</a>  CDataRecoveryHandler::SetAutosaveInterval  
 Sets the time between autosave cycles in milliseconds.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 The new autosave interval in milliseconds.  
  
##  \<a name="cdatarecoveryhandler__setautosavepath">\</a>  CDataRecoveryHandler::SetAutosavePath  
 Sets the directory where autosaved files are stored.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>|The path where autosave files are stored.|  
  
### Remarks  
 Changing the autosave directory does not move currently autosaved files.  
  
##  \<a name="cdatarecoveryhandler__setrestartidentifier">\</a>  CDataRecoveryHandler::SetRestartIdentifier  
 Sets the unique restart identifier for this instance of the <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>|The unique identifier for the restart manager.|  
  
### Remarks  
 The restart manager records information about the open documents in the registry. This information is stored with the unique restart identifier as the key. Because the restart identifier is unique for each instance of an application, multiple instances of an application may exit unexpectedly and the restart manager can recover each of them.  
  
##  \<a name="cdatarecoveryhandler__setsavedocumentinfoonidle">\</a>  CDataRecoveryHandler::SetSaveDocumentInfoOnIdle  
 Sets whether the <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> saves the open document information to the Windows registry during the current idle cycle.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>187\</CodeContentPlaceHolder> to save document information during the current idle cycle; <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>.|  
  
##  \<a name="cdatarecoveryhandler__setshutdownbyrestartmanager">\</a>  CDataRecoveryHandler::SetShutdownByRestartManager  
 Sets whether the previous exit of the application was caused by the restart manager.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>190\</CodeContentPlaceHolder> to indicate that the restart manager caused the application to exit; <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> to indicate that the application exited for another reason.|  
  
### Remarks  
 The framework behaves differently based on whether the previous exit was unexpected or whether it was initiated by the restart manager.  
  
##  \<a name="cdatarecoveryhandler__updatedocumentinfo">\</a>  CDataRecoveryHandler::UpdateDocumentInfo  
 Updates the information for a document because the user saved it.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>|A pointer to the saved document.|  
  
### Return Value  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> if this method deleted the autosaved document and updated the document information; <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> if an error occurred.  
  
### Remarks  
 When a user saves a document, the application removes the autosaved file because it is no longer needed. <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> deletes the autosaved file by calling [CDataRecoveryHandler::RemoveDocumentInfo](#cdatarecoveryhandler__removedocumentinfo). <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> then adds the information from <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> to the list of currently open documents because <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> deletes that information, but the saved document is still open.  
  
 To use this method, <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> parameter.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject Class](../vs140/cobject-class.md)   
 [How to: Add Restart Manager Support](../vs140/how-to--add-restart-manager-support.md)