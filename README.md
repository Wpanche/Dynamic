## Requerimientos
* [PostMan](https://www.getpostman.com/downloads)

## Abrir solición
* Clonar repositorio:```git clone https://gitlab.com/wilmarpanche/arbolbinario.git```
* En director ``./arbolBinario`` ejecutar el archivo ``arbolBinario.sln``

## Getting started

1. Install the tools listed in the "Requirements" section.
1. Download the REST API schema and save it in the `/res` folder under the folder where this README file is. For more information about the schema, see the following documentation:

   <http://onlinehelp.tableau.com/current/api/rest_api/en-us/help.htm#REST/rest_api_concepts_schema.htm>

1. In the `/res` folder, open the `config.properties` file using a text editor.
1. Modify the configurations as instructed in the file. A sample workbook is already provided with this sample, but you can use any packaged workbook that you want.
1. Open the following file in a text editor:

   ```
   src\com\tableausoftware\documentation\api\rest\util\RestApiUtils.java
   ```

1. Find the `getApiUriBuilder()` method, and replace the API URL with the correct version number.

   For example, you might see the following URL:

   ```
   /api/3.4/
   ```

   If you want to use version 3.3 of the API, replace the URL with the following:

   ```
   /api/3.3/
   ```

## Running the sample

1. Make sure that Tableau Server is running.
1. Open a command prompt or terminal.
1. In the command prompt window, change directory to the sample code's parent folder.
1. Enter `ant` in the command prompt to compile the sample code and download dependencies.
1. Enter `ant run` in the command prompt to run the sample code after compilation.

## Possible problems

When `ant` is run in a command prompt, it may respond with "ant is not recognized as an internal or external command..."

Make sure that the `ANT_HOME` and `JAVA_HOME` variables are set as described in the installation guide for Apache Ant. Paths should not include quotes.
For more information, see <http://ant.apache.org/manual/install.html#windows>
