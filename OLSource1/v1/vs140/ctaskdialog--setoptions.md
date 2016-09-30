---
title: "CTaskDialog::SetOptions"
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
  - "CTaskDialog::SetOptions"
  - "CTaskDialog.SetOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOptions method"
ms.assetid: 8ff81690-3bba-4546-806d-7af79d502355
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetOptions
Configures the options for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The set of flags to use for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method clears all the current options for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. To preserve the current options, you must retrieve them first with [CTaskDialog::GetOptions](../vs140/ctaskdialog--getoptions.md) and combine them with the options that you want to set.  
  
 The following table lists all the valid options.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Enables hyperlinks in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Configures the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to use a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for the main icon. The alternative is to use a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Configures the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to use a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for the footer icon. The alternative is to use a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Enables the user to close the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> by using the keyboard or by using the icon in the upper-right corner of the dialog box, even if the **Cancel** button is not enabled. If this flag is not set and the **Cancel** button is not enabled, the user cannot close the dialog box by using Alt+F4, the Escape key, or the title bar's close button.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Configures the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to use command button controls.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Configures the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to use command button controls without displaying an icon next to the control. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> overrides <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Indicates the expansion area is currently expanded.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Determines whether the expansion area is expanded by default.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Indicates the verification check box is currently selected.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Configures the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to display a progress bar.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Configures the progress bar to be a marquee progress bar. If you enable this option, you must set <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to have the expected behavior.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Indicates that the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> callback interval is set to approximately 200 milliseconds.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Configures the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to be centered relative to the parent window. If this flag is not enabled, the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is centered relative to the monitor.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Configures the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> for a right-to-left reading layout.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Indicates that no radio button is selected when the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> appears.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Enables the user to minimize the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. To support this option, the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> cannot be modal. MFC does not support this option because MFC does not support a modeless <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--setoptions_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::GetOptions](../vs140/ctaskdialog--getoptions.md)