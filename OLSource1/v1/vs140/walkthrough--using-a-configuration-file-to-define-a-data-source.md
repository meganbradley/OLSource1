---
title: "Walkthrough: Using a Configuration File to Define a Data Source"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "configuration files [Visual Studio ALM], defining data sources"
  - "unit tests, walkthrough"
  - "data sources, defining with configuration files"
ms.assetid: 95fa5214-b12e-4e1f-84e5-cc4c2d86b0d7
caps.latest.revision: 36
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Using a Configuration File to Define a Data Source
This walkthrough illustrates how to use a data source defined in an app.config file for unit testing. You will learn how to create an app.config file that defines a data source that can be used by the \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute*> class. Tasks presented in this walkthrough include the following:  
  
-   Creating an app.config file.  
  
-   Defining a custom configuration section.  
  
-   Defining connection strings.  
  
-   Defining the data sources.  
  
-   Accessing the data sources using the \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute*> class.  
  
## Prerequisites  
 To complete this walkthrough, you will need:  
  
-   Visual Studio Enterprise  
  
-   Either Microsoft Access or Microsoft Excel to provide data for at least one of the test methods.  
  
-   A Visual Studio solution that contains a test project.  
  
## Create the App.config File  
  
#### To add an app.config file to the project  
  
1.  If your test project already has an app.config file, go to [Define a Custom Configuration Section](#DefineCustomConfigurationSection).  
  
2.  Right-click your test project in the **Solution Explorer**, point to **Add**, and then click **New Item**.  
  
     The **Add New Item** window opens.  
  
3.  Select the **Application Configuration File** template and click **Add**.  
  
##  \<a name="DefineCustomConfigurationSection">\</a> Define a Custom Configuration Section  
 Examine the app.config file. It contains at least the XML declaration and a root element.  
  
#### To add the custom configuration section to the app.config file  
  
1.  The root element of app.config should be the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element. Create a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element within the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> should be the first element in the app.config file.  
  
2.  Within the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element, create a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element.  
  
3.  In the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element, add an attribute called <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and assign it a value equal <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Add another attribute called <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and assign it a value equal <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element should look similar to this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  The assembly name must match the Microsoft Visual Studio .NET Framework build that you are using. Set the Version to 9.0.0.0 if you are using the Visual Studio .NET Framework 3.5. If you are using the Visual Studio .NET Framework 2.0, set the Version to 8.0.0.0.  
  
## Define Connection Strings  
 The connection strings define provider specific information for accessing data sources. Connection strings defined in configuration files provide reusable data provider information across an application. In this section, you create two connection strings that will be used by data sources that are defined in the Custom Configuration Section.  
  
#### To define connection strings  
  
1.  After the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element, create a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element.  
  
2.  Within the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> element, create two <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> elements.  
  
3.  In the first <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element, create the following attributes and values for a connection to a Microsoft Access database:  
  
|Attribute|Values|  
|---------------|------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
  
 In the second <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> element, create the following attributes and values for a connection to a Microsoft Excel spreadsheet:  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> element should look similar to this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Define Data Sources  
 The data sources section contains four attributes that are used by the test engine to retrieve data from a data source.  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> defines the identity used by the \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute*> to specify which data source to use.  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> identifies the connection string created in the previous Define Connection Strings section.  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> defines the table or sheet that holds the data to use in the test.  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> defines the technique for accessing data values in the data source.  
  
 In this section, you will define two data sources to use in a unit test.  
  
#### To define data sources  
  
1.  After the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> element, create a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> element. This section was created in Define a Custom Configuration Section.  
  
2.  Within the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> element, create a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> element.  
  
3.  Within the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> element, create two <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> elements.  
  
4.  In the first <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> element, create the following attributes and values for a Microsoft Access data source:  
  
|Attribute|Values|  
|---------------|------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
  
 In the second <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> element, create the following attributes and values for a Microsoft Excel data source:  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> element should look similar to this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The final app.config file should look similar to this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Create a Unit Test Using Data Sources Defined in app.config  
 Now that an app.config file has been defined, you will create a unit test that uses data located in the data sources that are defined in the app.config file. In this section, we will:  
  
-   Create the data sources found in the app.config file.  
  
-   Use the data sources in two test methods that compare the values in each data source.  
  
#### To create a Microsoft Access data source  
  
1.  Create a Microsoft Access database named <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
2.  Create a table and name it <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
3.  Create two fields in <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> named <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> using the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> data type.  
  
4.  Add five entities to <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> with the following values for <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, respectively: (10,50), (3,2), (6,0), (0,8) and (12312,1000).  
  
5.  Save and close the database.  
  
6.  Change the connection string to point to the location of the database. Change the value of <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> to reflect the location of the database.  
  
#### To create a Microsoft Excel data source  
  
1.  Create a Microsoft Excel spreadsheet named <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
2.  Create a sheet named <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> if it does not already exist in <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
3.  Create two column headers and name them <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
4.  Add five entities to <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> with the following values for <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, respectively: (1,1), (2,2), (3,3), (4,4) and (5,0).  
  
5.  Save and close the spreadsheet.  
  
6.  Change the connection string to point to the location of the spreadsheet. Change the value of <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to reflect the location of the spreadsheet.  
  
#### To create a unit test using the app.config data sources  
  
1.  Add a unit test to the test project.  
  
     For more information, see [Creating and Running Unit Tests for Existing Code](assetId:///e8370b93-085b-41c9-8dec-655bd886f173).  
  
2.  Replace the auto-generated contents of the unit test with the following code:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
3.  Examine the DataSource attributes. Notice the setting names from the app.config file.  
  
4.  Build your solution and run MyTestMethod and MyTestMethod2 tests.  
  
> [!IMPORTANT]
>  Deploy items like data sources so that they are accessible to the test in the deployment directory.  
  
## See Also  
 [Verifying Code by Using Unit Tests](../vs140/unit-test-your-code.md)   
 [Creating and Running Unit Tests for Existing Code](assetId:///e8370b93-085b-41c9-8dec-655bd886f173)   
 [Testing the application](assetId:///796b7d6d-ad45-4772-9719-55eaf5490dac)   
 [Coding a Data-Driven Unit Test](../vs140/how-to--create-a-data-driven-unit-test.md)