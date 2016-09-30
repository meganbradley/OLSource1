---
title: "LPTEXTOUTPROC"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "LPTEXTOUTPROC"
helpviewer_keywords: 
  - "SccMsgDataOnMessage structure"
  - "SccMsgDataOnBeforeGetFile structure"
  - "SccMsgDataIsCancelled structure"
  - "LPTEXTOUTPROC callback function"
  - "SccMsgDataOnAfterGetFile structure"
ms.assetid: 2025c969-e3c7-4cf4-a5c5-099d342895ea
caps.latest.revision: 25
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# LPTEXTOUTPROC
When the user executes a source control operation from inside the integrated development environment (IDE), the source control plug-in might want to convey error or status messages relating to the operation. The plug-in can display its own message boxes for this purpose. However, for more seamless integration, the plug-in can pass strings to the IDE, which then displays them in its native way of displaying status information. The mechanism for this is the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function pointer. The IDE implements this function (described in more detail below) for displaying error and status.  
  
 The IDE passes to the source control plug-in a function pointer to this function, as the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter, when calling the [SccOpenProject Function](../vs140/sccopenproject-function.md). During an SCC operation, for example, in the middle of a call to the [SccGet Function](../vs140/sccget-function.md) involving many files, the plug-in can call the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function, periodically passing strings to display. The IDE may display these strings on a status bar, in an output window, or in a separate message box, as appropriate. Optionally, the IDE may be able to display certain messages with a **Cancel** button. This enables the user to cancel the operation, and it gives the IDE the ability to pass this information back to the plug-in.  
  
## Signature  
 The IDE's output function has the following signature:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parameters  
 display_string  
 A text string to display. This string should not be terminated with a carriage return or a line feed.  
  
 mesg_type  
 The type of message. The following table lists the supported values for this parameter.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The message is considered Information, Warning, or Error.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The message shows status and can be displayed in the status bar.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Sent with no message string.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Begins displaying a **Cancel** button.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Stops displaying a **Cancel** button.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Asks IDE if the background operation is to be cancelled: IDE returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if operation was cancelled; otherwise, returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter is cast as an [SccMsgDataIsCancelled](#LinkSccMsgDataIsCancelled) structure, which is supplied by the source control plug-in.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Tells the IDE about a file before it is retrieved from version control. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter is cast as an [SccMsgDataOnBeforeGetFile](#LinkSccMsgDataOnBeforeGetFile) structure, which is supplied by the source control plug-in.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Tells the IDE about a file after it has been retrieved from version control. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter is cast as an [SccMsgDataOnAfterGetFile](#LinkSccMsgDataOnAfterGetFile) structure, which is supplied by the source control plug-in.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Tells the IDE of the current status of a background operation. The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter is cast as an [SccMsgDataOnMessage](#LinkSccMsgDataOnMessage) structure, which is supplied by the source control plug-in.|  
  
## Return Value  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_MSG_RTN_OK|The string was displayed or the operation was completed successfully.|  
|SCC_MSG_RTN_CANCEL|The user wants to cancel the operation.|  
  
## Example  
 Suppose the IDE calls the [SccGet Function](../vs140/sccget-function.md) with twenty file names. The source control plug-in wants to prevent canceling the operation in the middle of a file get. After getting each file, it calls <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, passing it the status information on each file, and sends a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> message if it has no status to report. If at any time the plug-in receives a return value of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> from the IDE, it cancels the get operation immediately, so that no more files are retrieved.  
  
## Structures  
  
###  \<a name="LinkSccMsgDataIsCancelled">\</a> SccMsgDataIsCancelled  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This structure is sent with the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> message. It is used to communicate the ID of the background operation that was canceled.  
  
###  \<a name="LinkSccMsgDataOnBeforeGetFile">\</a> SccMsgDataOnBeforeGetFile  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This structure is sent with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> message. It is used to communicate the name of the file about to be retrieved and the ID of the background operation that is doing the retrieving.  
  
###  \<a name="LinkSccMsgDataOnAfterGetFile">\</a> SccMsgDataOnAfterGetFile  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This structure is sent with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> message. It is used to communicate the result of retrieving the specified file as well as the ID of the background operation that did the retrieving. See the return values for the [SccGet Function](../vs140/sccget-function.md) for what can be given as a result.  
  
###  \<a name="LinkSccMsgDataOnMessage">\</a> SccMsgDataOnMessage  
 [C++]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This structure is sent with the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> message. It is used to communicate the current status of a background operation. The status is expressed as a string to be displayed by the IDE, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> indicates the severity of the message (<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> for an error message; <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> for a warning or for an informational message). The ID of the background operation sending the status is also given.  
  
## Code Example  
 Here is a brief example of calling <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to send the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> message, showing how to cast the structure for the call.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Callback Functions Implemented by the IDE](../vs140/callback-functions-implemented-by-the-ide.md)   
 [Source Control Plug-ins](../vs140/source-control-plug-ins.md)