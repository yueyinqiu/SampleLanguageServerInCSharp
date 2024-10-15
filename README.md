1. open `Server/Server.sln` with Visual Studio
2. build and run (debug) the project
3. open `Client/Client.code-workspace` with Visual Studio Code
4. call `npm install` in a terminal
5. ensure the `dll` produced in step 2 is under `Server/Server/bin/Debug/net8.0`
    - if not, edit the path in `Client\src\extension.ts`
6. run with the given launch configuration