---
title: "CTaskDialog::TaskDialogCallback"
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
  - "CTaskDialog::TaskDialogCallback"
  - "CTaskDialog.TaskDialogCallback"
  - "TaskDialogCallback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TaskDialogCallback method"
ms.assetid: 64bd1dea-c8c9-4a4e-8f2f-d72ad8cb652f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::TaskDialogCallback
The framework calls this method in response to various Windows messages.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The notification code that specifies the generated message.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 More information about the message.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 More information about the message.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that the callback message applies to.  
  
## Return Value  
 Depends on the specific notification code. See the Remarks section for more information.  
  
## Remarks  
 The default implementation of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> handles the specific message and then calls the appropriate On method of the [CTaskDialog Class](../vs140/ctaskdialog-class.md). For example, in response to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> message, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> calls [CTaskDialog::OnCommandControlClick](../vs140/ctaskdialog--oncommandcontrolclick.md).  
  
 The values for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> depend on the specific generated message. It is possible for either or both of these values to be empty. The following table lists the default notifications that are supported and what the values of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> represent. If you override this method in a derived class, you should implement the callback code for each message in the following table.  
  
|Notification Message|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> Value|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> Value|  
|--------------------------|--------------------|--------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Not used.|Not used.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Not used.|Not used.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|The command button control ID.|Not used.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Not used.|A [LPCWSTR](http://msdn.microsoft.com/library/windows/desktop/aa383751) structure that contains the link.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Time in milliseconds since the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> was created or the timer was reset.|Not used.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Not used.|Not used.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The radio button ID.|Not used.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Not used.|Not used.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|1 if the check box is checked, 0 if it is not.|Not used.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Not used.|Not used.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|0 if the expansion area is collapsed; nonzero if the expansion text is displayed.|Not used.|  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::OnCommandControlClick](../vs140/ctaskdialog--oncommandcontrolclick.md)   
 [CTaskDialog::OnCreate](../vs140/ctaskdialog--oncreate.md)   
 [CTaskDialog::OnDestroy](../vs140/ctaskdialog--ondestroy.md)   
 [CTaskDialog::OnExpandButtonClick](../vs140/ctaskdialog--onexpandbuttonclick.md)   
 [CTaskDialog::OnHelp](../vs140/ctaskdialog--onhelp.md)   
 [CTaskDialog::OnHyperlinkClick](../vs140/ctaskdialog--onhyperlinkclick.md)   
 [CTaskDialog::OnInit](../vs140/ctaskdialog--oninit.md)   
 [CTaskDialog::OnNavigatePage](../vs140/ctaskdialog--onnavigatepage.md)   
 [CTaskDialog::OnRadioButtonClick](../vs140/ctaskdialog--onradiobuttonclick.md)   
 [CTaskDialog::OnTimer](../vs140/ctaskdialog--ontimer.md)   
 [CTaskDialog::OnVerificationCheckboxClick](../vs140/ctaskdialog--onverificationcheckboxclick.md)