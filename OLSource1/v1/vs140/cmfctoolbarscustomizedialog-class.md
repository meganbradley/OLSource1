---
title: "CMFCToolBarsCustomizeDialog Class"
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
  - "CMFCToolBarsCustomizeDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarsCustomizeDialog class"
ms.assetid: 78e2cddd-4f13-4097-afc3-1ad646a113f1
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog Class
A modeless tab dialog box ( [CPropertySheet](../vs140/cpropertysheet-class.md)) that enables the user to customize the toolbars, menus, keyboard shortcuts, user-defined tools, and visual style in an application. Typically, the user accesses this dialog box by selecting **Customize** from the **Tools** menu.  
  
 The **Customize** dialog box has six tabs: **Commands**, **Toolbars**, **Tools**, **Keyboard**, **Menu**, and **Options**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog](#cmfctoolbarscustomizedialog__cmfctoolbarscustomizedialog)|Constructs a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> [AddButton](#cmfctoolbarscustomizedialog__addbutton)|Inserts a toolbar button into the list of commands on the **Commands** page|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> [AddMenu](#cmfctoolbarscustomizedialog__addmenu)|Loads a menu from the resources and calls [ToolBarsCustomizeDialog::AddMenuCommands](#cmfctoolbarscustomizedialog__addmenucommands) to add that menu to the list of commands on the **Commands** page.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> [AddMenuCommands](#cmfctoolbarscustomizedialog__addmenucommands)|Loads a menu from the resources and calls [ToolBarsCustomizeDialog::AddMenuCommands](#cmfctoolbarscustomizedialog__addmenucommands) to add that menu to the list of commands on the **Commands** page.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> [AddToolBar](#cmfctoolbarscustomizedialog__addtoolbar)|Loads a toolbar from the resources. Then, for each command in the menu calls the [AddButton](#cmfctoolbarscustomizedialog__addbutton) method to insert a button in the list of commands on the **Commands** page under the specified category.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> [Create](#cmfctoolbarscustomizedialog__create)|Displays the **Customization** dialog box.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Reserved for future use.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> [EnableUserDefinedToolbars](#cmfctoolbarscustomizedialog__enableuserdefinedtoolbars)|Enables or disables creating new toolbars by using the **Customize** dialog box.|  
|[CMFCToolBarsCustomizeDialog::FillAllCommandsList](#cmfctoolbarscustomizedialog__fillallcommandslist)|Populates the provided <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object with the commands in the **All Commands** category.|  
|[CMFCToolBarsCustomizeDialog::FillCategoriesComboBox](#cmfctoolbarscustomizedialog__fillcategoriescombobox)|Populates the provided <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object with the name of each command category in the **Customize** dialog box.|  
|[CMFCToolBarsCustomizeDialog::FillCategoriesListBox](#cmfctoolbarscustomizedialog__fillcategorieslistbox)|Populates the provided <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object with the name of each command category in the **Customize** dialog box.|  
|[CMFCToolBarsCustomizeDialog::GetCommandName](#cmfctoolbarscustomizedialog__getcommandname)|Retrieves the name that is associated with the given command ID.|  
|[CMFCToolBarsCustomizeDialog::GetCountInCategory](#cmfctoolbarscustomizedialog__getcountincategory)|Retrieves the number of items in the provided list that have a given text label.|  
|[CMFCToolBarsCustomizeDialog::GetFlags](#cmfctoolbarscustomizedialog__getflags)|Retrieves the set of flags that affect the behavior of the dialog box.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder> [OnEditToolbarMenuImage](#cmfctoolbarscustomizedialog__onedittoolbarmenuimage)|Starts an image editor so that a user can customize a toolbar button or menu item icon.|  
|[CMFCToolBarsCustomizeDialog::OnInitDialog](#cmfctoolbarscustomizedialog__oninitdialog)|Overrides to augment property sheet initialization. (Overrides [CPropertySheet::OnInitDialog](../vs140/cpropertysheet-class.md#cpropertysheet__oninitdialog).)|  
|[CMFCToolBarsCustomizeDialog::PostNcDestroy](#cmfctoolbarscustomizedialog__postncdestroy)|Called by the framework after the window has been destroyed. (Overrides <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.)|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder> [RemoveButton](#cmfctoolbarscustomizedialog__removebutton)|Removes the button with the specified command ID from the specified category, or from all categories.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder> [RenameCategory](#cmfctoolbarscustomizedialog__renamecategory)|Renames a category in the list box of categories on the **Commands** tab.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> [ReplaceButton](#cmfctoolbarscustomizedialog__replacebutton)|Replaces a button in the list of commands on the **Commands** tab with a new toolbar button object.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder> [SetUserCategory](#cmfctoolbarscustomizedialog__setusercategory)|Adds a category to the list of categories that will be displayed on the **Commands** tab.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> [CheckToolsValidity](#cmfctoolbarscustomizedialog__checktoolsvalidity)|Called by the framework to determine whether the list of user-defined tools is valid.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder> [OnAfterChangeTool](#cmfctoolbarscustomizedialog__onafterchangetool)|Called by the framework when the properties of a user-defined tool change.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> [OnAssignKey](#cmfctoolbarscustomizedialog__onassignkey)|Determines whether a specified keyboard shortcut can be assigned to an action.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> [OnBeforeChangeTool](#cmfctoolbarscustomizedialog__onbeforechangetool)|Determines whether a user-defined tool can be changed.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder> [OnInitToolsPage](#cmfctoolbarscustomizedialog__oninittoolspage)|Called by the framework when the user chooses the **Tools** tab is requested.|  
  
## Remarks  
 To display the **Customize** dialog box, create a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object and call the [Create](#cmfctoolbarscustomizedialog__create) method.  
  
 While the **Customize** dialog box is active, the application works in a special mode that limits the user to customization tasks.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> class. The example shows how to replace a toolbar button in the list box of commands on the **Commands** page, enable creating new toolbars by using the **Customize** dialog box, and display the **Customization** dialog box. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#4](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CPropertySheet](../vs140/cpropertysheet-class.md)  
  
 [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md)  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
##  \<a name="cmfctoolbarscustomizedialog__addbutton">\</a>  CMFCToolBarsCustomizeDialog::AddButton  
 Inserts a toolbar button into the list of commands on the **Commands** page.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Specifies the category ID into which to insert the button.  
  
 [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Specifies the button to insert.  
  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Specifies the zero-based index of a toolbar button before which the button is inserted.  
  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Specifies the category string to insert the button.  
  
### Remarks  
 The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> method ignores buttons that have the standard command IDs (such as ID_FILE_MRU_FILE1), commands that are not permitted (see [CMFCToolBar::IsCommandPermitted](../vs140/cmfctoolbar-class.md#cmfctoolbar__iscommandpermitted)) and dummy buttons.  
  
 This method creates a new object of the same type as <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> (usually a [CMFCToolbarButton](../vs140/cmfctoolbarbutton-class.md)) by using the runtime class of the button. It then calls [CMFCToolBarButton::CopyFrom](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__copyfrom) to copy the data members of button, and inserts the copy into the specified category.  
  
 When the new button is inserted, it receives the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> notification.  
  
 If <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is -1, the button is appended to the list of categories; otherwise it is inserted before the item with the specified index.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> class. This code snippet is part of the [Slider sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_Slider#1](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog-class_2.cpp)]  
  
##  \<a name="cmfctoolbarscustomizedialog__addmenu">\</a>  CMFCToolBarsCustomizeDialog::AddMenu  
 Loads a menu from the resources and calls [ToolBarsCustomizeDialog::AddMenuCommands](#cmfctoolbarscustomizedialog__addmenucommands) to add that menu to the list of commands on the **Commands** page.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Specifies the resource ID of a menu to load.  
  
### Return Value  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> if a menu was added successfully; otherwise <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
### Remarks  
 In the call to <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. As a result, that method does not add menu items that contain submenus to the list of commands. This method does add the menu items in the submenus to the list of commands.  
  
##  \<a name="cmfctoolbarscustomizedialog__addmenucommands">\</a>  CMFCToolBarsCustomizeDialog::AddMenuCommands  
 Adds items to the list of commands in the **Commands** page to represent all the items in the specified menu.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A pointer to the CMenu object to add.  
  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Specifies whether to insert the popup menu items to the list of commands.  
  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The name of the category to insert the menu.  
  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 A prefix that is added to the name when the command is shown in the **All Categories** list.  
  
### Remarks  
 The <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> method loops over all menu items of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>. For each menu item that does not contain a submenu, this method creates a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object and calls the [AddButton](#cmfctoolbarscustomizedialog__addbutton) method to add the menu item as a toolbar button to the list of commands on the **Commands** page. Separators are ignored in this process.  
  
 If <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, for each menu item that contains a submenu this method creates a [CMFCToolBarMenuButton](../vs140/cmfctoolbarmenubutton-class.md) object and inserts it into the list of commands by calling <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. Otherwise menu items that contain submenus are not displayed in the list of commands. In either case, when <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> encounters a menu item with a submenu it calls itself recursively, passing a pointer to the submenu as the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> parameter and appending the label of the submenu to <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarscustomizedialog__addtoolbar">\</a>  CMFCToolBarsCustomizeDialog::AddToolBar  
 Loads a toolbar from the resources. Then, for each command in the menu calls the [AddButton](#cmfctoolbarscustomizedialog__addbutton) method to insert a button in the list of commands on the **Commands** page under the specified category.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Specifies the resource ID of the category to add the toolbar to.  
  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 Specifies the resource ID of a toolbar whose commands are inserted into the list of commands.  
  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 Specifies the name of the category to which to add the toolbar.  
  
### Return Value  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> if the method is successful; otherwise <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> class. This code snippet is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#11](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog-class_3.cpp)]  
  
### Remarks  
 The control that is used to represent each command is a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object. After you add the toolbar, you can replace the button with a control of a derived type by calling [CMFCToolBarsCustomizeDialog::ReplaceButton](#cmfctoolbarscustomizedialog__replacebutton).  
  
##  \<a name="cmfctoolbarscustomizedialog__checktoolsvalidity">\</a>  CMFCToolBarsCustomizeDialog::CheckToolsValidity  
 Verifies the validity of the list of user tools.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The list of user-defined tools to check.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> if the list of user-defined tools is valid; otherwise <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. The default implementation always returns <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to verify the validity of objects that represent user-defined tools returned by [CUserToolsManager::GetUserTools](#cmfctoolbarscustomizedialog__checktoolsvalidity).  
  
 Override the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> method in a class derived from [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md) if you want to validate the user tools before the user closes the dialog box. If this method returns <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> when the user clicks either the **Close** button in the upper-right corner of the dialog box or the button labeled **Close** in the lower-right corner of the dialog box, the dialog box displays the **Tools** tab instead of closing. If this method returns <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> when the user clicks a tab to navigate away from the **Tools** tab, the navigation does not occur. You should display an appropriate message box to inform the user of the problem that caused validation to fail.  
  
##  \<a name="cmfctoolbarscustomizedialog__cmfctoolbarscustomizedialog">\</a>  CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog  
 Constructs a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 A pointer to the parent frame. This parameter must not be <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to add the menu commands from all menus to the list of commands on the **Commands** page. If this parameter is <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, the menu commands are added. Otherwise, the menu commands are not added.  
  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A combination of flags that affect the behavior of the dialog box. This parameter can be one or more of the following values:  
  
-   <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 A pointer to a list of <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> objects that specify additional custom pages.  
  
### Remarks  
 The <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> parameter refers to the list of <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> objects that specify additional custom pages. The constructor adds more pages to the dialog box by using the [CRuntimeClass::CreateObject](../vs140/cruntimeclass-structure.md#cruntimeclass__createobject) method. See the CustomPages sample for an example that adds more pages to the **Customize** dialog box.  
  
 For more information about the values that you can pass in the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> parameter, see [CMFCToolBarsCustomizeDialog::GetFlags](#cmfctoolbarscustomizedialog__getflags).  
  
### Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> class. This code snippet is part of the [Custom Pages sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_CustomPages#3](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog-class_4.cpp)]  
  
##  \<a name="cmfctoolbarscustomizedialog__create">\</a>  CMFCToolBarsCustomizeDialog::Create  
 Displays the **Customization** dialog box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> if the customization property sheet is created successfully; otherwise <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> method only after you fully initialize the class.  
  
##  \<a name="cmfctoolbarscustomizedialog__enableuserdefinedtoolbars">\</a>  CMFCToolBarsCustomizeDialog::EnableUserDefinedToolbars  
 Enables or disables creating new toolbars by using the **Customize** dialog box.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> to enable the user-defined toolbars; <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> to disable the toolbars.  
  
### Remarks  
 If <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, the **New**, **Rename** and **Delete** buttons are displayed on the **Toolbars** page.  
  
 By default, or if <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, these buttons are not displayed and the user cannot define new toolbars.  
  
##  \<a name="cmfctoolbarscustomizedialog__fillallcommandslist">\</a>  CMFCToolBarsCustomizeDialog::FillAllCommandsList  
 Populates the provided <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> object with the commands in the **All Commands** category.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> object to populate.  
  
### Remarks  
 The **All Commands** category contains the commands of all categories. The [CMFCToolBarsCustomizeDialog::AddButton](#cmfctoolbarscustomizedialog__addbutton) method adds the command that is associated with the provided button to the **All Commands** category for you.  
  
 This method clears the contents of the provided <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object before populating it with the commands in the **All Commands** category.  
  
 The <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> class uses this method to populate the double-click event list box.  
  
##  \<a name="cmfctoolbarscustomizedialog__fillcategoriescombobox">\</a>  CMFCToolBarsCustomizeDialog::FillCategoriesComboBox  
 Populates the provided <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object with the name of each command category in the **Customize** dialog box.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object to populate.  
  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to add categories to the combo box that do not have commands. If this parameter is <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>, empty categories are added to the combo box. Otherwise, empty categories are not added.  
  
### Remarks  
 This method is like the [CMFCToolBarsCustomizeDialog::FillCategoriesListBox](#cmfctoolbarscustomizedialog__fillcategorieslistbox) method except that this method works with a <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> object.  
  
 This method does not clear the contents of the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object before populating it. It guarantees that the **All Commands** category is the final item in the combo box.  
  
 You can add new command categories by using the [CMFCToolBarsCustomizeDialog::AddButton](#cmfctoolbarscustomizedialog__addbutton) method. You can change the name of an existing category by using the [CMFCToolBarsCustomizeDialog::RenameCategory](#cmfctoolbarscustomizedialog__renamecategory) method.  
  
 The <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> classes use this method to categorize keyboard mappings.  
  
##  \<a name="cmfctoolbarscustomizedialog__fillcategorieslistbox">\</a>  CMFCToolBarsCustomizeDialog::FillCategoriesListBox  
 Populates the provided <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> object with the name of each command category in the **Customize** dialog box.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> object to populate.  
  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to add categories to the list box that do not have commands. If this parameter is <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>, empty categories are added to the list box. Otherwise, empty categories are not added.  
  
### Remarks  
 This method is like the [CMFCToolBarsCustomizeDialog::FillCategoriesComboBox](#cmfctoolbarscustomizedialog__fillcategoriescombobox) method except that this method works with a <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object.  
  
 This method does not clear the contents of the <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> object before populating it. It guarantees that the **All Commands** category is the final item in the list box.  
  
 You can add new command categories by using the [CMFCToolBarsCustomizeDialog::AddButton](#cmfctoolbarscustomizedialog__addbutton) method. You can change the name of an existing category by using the [CMFCToolBarsCustomizeDialog::RenameCategory](#cmfctoolbarscustomizedialog__renamecategory) method.  
  
 The <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> class uses this method to show the list of commands that is associated with each command category.  
  
##  \<a name="cmfctoolbarscustomizedialog__getcommandname">\</a>  CMFCToolBarsCustomizeDialog::GetCommandName  
 Retrieves the name that is associated with the given command ID.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 The ID of the command to retrieve.  
  
### Return Value  
 The name that is associated with the given command ID, or <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> if the command does not exist.  
  
##  \<a name="cmfctoolbarscustomizedialog__getcountincategory">\</a>  CMFCToolBarsCustomizeDialog::GetCountInCategory  
 Retrieves the number of items in the provided list that have a given text label.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 The text label to match.  
  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 A reference to a list that contains <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> objects.  
  
### Return Value  
 The number of items in the provided list whose text label equals <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
### Remarks  
 Each element in the provided object list must be of type <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>. This method compares <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> with the [CMFCToolBarButton::m_strText](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__m_strtext) data member.  
  
##  \<a name="cmfctoolbarscustomizedialog__getflags">\</a>  CMFCToolBarsCustomizeDialog::GetFlags  
 Retrieves the set of flags that affect the behavior of the dialog box.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The set of flags that affect the behavior of the dialog box.  
  
### Remarks  
 This method retrieves the value of the <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> parameter that is passed to the constructor. The return value can be one or more of the following values:  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Allows the user to specify the shadow appearance of the menu.  
  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 Allows the user to specify whether text labels are shown underneath the toolbar button images.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 Allows the user to specify the menu animation style.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 Removes the help button from the customization dialog box.  
  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 Enables the <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> visual style.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 Removes the **Tools** page from the customization dialog box. This flag is valid if your application uses the <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 Allows button captions to contain the ampersand ( **&**) character.  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Removes the **Large Icons** option from the customization dialog box.  
  
 For more information about the <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> visual style, see [Extended Window Styles](../vs140/extended-window-styles.md).  
  
##  \<a name="cmfctoolbarscustomizedialog__onafterchangetool">\</a>  CMFCToolBarsCustomizeDialog::OnAfterChangeTool  
 Responds to a change in a user tool immediately after it occurs.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 A pointer to the user tool object that has been changed.  
  
### Remarks  
 This method is called by the framework when a user changes the properties of a user-defined tool. The default implementation does nothing. Override this method in a class derived from [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md) to perform processing after a change to a user tool occurs.  
  
##  \<a name="cmfctoolbarscustomizedialog__onassignkey">\</a>  CMFCToolBarsCustomizeDialog::OnAssignKey  
 Validates keyboard shortcuts as a user defines them.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 Pointer to the proposed keyboard assigment that is expressed as an                                 [ACCEL](http://msdn.microsoft.com/library/windows/desktop/ms646340) struct.  
  
### Return Value  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> if the key can be assigned, or <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> if the key cannot be assigned. The default implementation always returns <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class to perform extra processing when a user assigns a new keyboard shortcut, or to validate keyboard shortcuts as the user defines them. To prevent a shortcut from being assigned, return <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>. You should also display a message box or otherwise inform the user of the reason why the keyboard shortcut was rejected.  
  
##  \<a name="cmfctoolbarscustomizedialog__onbeforechangetool">\</a>  CMFCToolBarsCustomizeDialog::OnBeforeChangeTool  
 Performs custom processing when a change to a user tool when the user is about to apply a change.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 A pointer to the user tool object that is about to be replaced.  
  
### Remarks  
 This method is called by the framework when the properties of a user-defined tool is about to change. The default implementation does nothing. Override the <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> method in a class derived from [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md) if you want to perform processing before a change to a user tool occurs, such as releasing resources that <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> uses.  
  
##  \<a name="cmfctoolbarscustomizedialog__onedittoolbarmenuimage">\</a>  CMFCToolBarsCustomizeDialog::OnEditToolbarMenuImage  
 Starts an image editor so that a user can customize a toolbar button or menu item icon.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 A pointer to the parent window.  
  
 [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 A reference to a bitmap object to be edited.  
  
 [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 Bitmap color resolution, in bits per pixel.  
  
### Return Value  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> if a change is being committed; otherwise <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>. The default implementation displays a dialog box and returns <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> if the user clicks **OK**, or <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> if the user clicks **Cancel** or the **Close** button.  
  
### Remarks  
 This method is called by the framework when the user runs the image editor. The default implementation displays [CMFCImageEditorDialog](../vs140/cmfcimageeditordialog-class.md) dialog box. Override <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> in a derived class to use a custom image editor.  
  
##  \<a name="cmfctoolbarscustomizedialog__oninitdialog">\</a>  CMFCToolBarsCustomizeDialog::OnInitDialog  
 Overrides to augment property sheet initialization.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The result of calling the [CPropertySheet::OnInitDialog](../vs140/cpropertysheet-class.md#cpropertysheet__oninitdialog) method.  
  
### Remarks  
 This method extends the base class implementation, [CPropertySheet::OnInitDialog](../vs140/cpropertysheet-class.md#cpropertysheet__oninitdialog), by displaying the **Close** button, by making sure that the dialog box fits the current screen size, and by moving the **Help** button to the lower-left corner of the dialog box.  
  
##  \<a name="cmfctoolbarscustomizedialog__oninittoolspage">\</a>  CMFCToolBarsCustomizeDialog::OnInitToolsPage  
 Handles the notification from the framework that the **Tools** page is about to be initialized.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation does nothing. Override this method in a derived class to process this notification.  
  
##  \<a name="cmfctoolbarscustomizedialog__postncdestroy">\</a>  CMFCToolBarsCustomizeDialog::PostNcDestroy  
 Called by the framework after the window has been destroyed.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 This method extends the base class implementation, <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>, by restoring the application to the previous mode.  
  
 The [CMFCToolBarsCustomizeDialog::Create](#cmfctoolbarscustomizedialog__create) method puts the application in a special mode that limits the user to customization tasks.  
  
##  \<a name="cmfctoolbarscustomizedialog__removebutton">\</a>  CMFCToolBarsCustomizeDialog::RemoveButton  
 Removes the button with the specified command ID from the specified category, or from all categories.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 Specifies the category ID from which to remove the button.  
  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 Specifies the command ID of the button.  
  
 [in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 Specifies the name of the category from which to remove the button.  
  
### Return Value  
 The zero-based index of the removed button, or -1 if the specified command ID was not found in the specified category. If <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> is -1, the return value is 0.  
  
### Remarks  
 To remove a button from all categories, call the first overload of this method and set <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> to -1.  
  
##  \<a name="cmfctoolbarscustomizedialog__renamecategory">\</a>  CMFCToolBarsCustomizeDialog::RenameCategory  
 Renames a category in the list box of categories on the **Commands** page.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 The category name to change.  
  
 [in] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The new category name.  
  
### Return Value  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>.  
  
### Remarks  
 The category name must be unique.  
  
##  \<a name="cmfctoolbarscustomizedialog__replacebutton">\</a>  CMFCToolBarsCustomizeDialog::ReplaceButton  
 Replaces a toolbar button in the list box of commands on the **Commands** page.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 Specifies the command of the button to be replaced.  
  
 [in] <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> reference to the toolbar button object that replaces the old button.  
  
### Remarks  
 When [CMFCToolBarsCustomizeDialog::AddMenu](#cmfctoolbarscustomizedialog__addmenu), [AddMenuCommands](#cmfctoolbarscustomizedialog__addmenucommands), or [AddToolbar](#cmfctoolbarscustomizedialog__addtoolbar) adds a command to the **Commands** page, that command is in the form of a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object (or a [CMFCToolBarMenuButton](../vs140/cmfctoolbarmenubutton-class.md) object for a menu item that contains a submenu added by <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>). The framework also calls these three methods to add commands automatically. If you want a command to be represented by a derived type instead, call <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> and pass in a button of the derived type.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> class. This code snippet is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#34](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog-class_5.cpp)]  
  
##  \<a name="cmfctoolbarscustomizedialog__setusercategory">\</a>  CMFCToolBarsCustomizeDialog::SetUserCategory  
 Specifies which category in the list of categories on the **Commands** page is the user category. You must call this function before you call [Create](#cmfctoolbarscustomizedialog__create).  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 The name of the category.  
  
### Return Value  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> if the method is successful; otherwise <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>.  
  
### Remarks  
 The user category setting is not currently used by the framework.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CPropertySheet](../vs140/cpropertysheet-class.md)