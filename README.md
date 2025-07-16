# ResumeBuilder

ResumeBuilder/                        <-- Root Git repo (or mono-repo)
│
├── ResumeBuilder.sln                <-- .NET Solution file (ties backend projects)
│
├── AuthService/                     <-- Handles user registration, login, JWT
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   ├── Services/
│   ├── AuthService.csproj
│   └── appsettings.json
│
├── ResumeService/                   <-- Resume CRUD, PDF generation
│   ├── Controllers/
│   ├── Models/
│   ├── Services/
│   ├── Data/
│   ├── ResumeService.csproj
│   └── appsettings.json
│
├── Shared/ (Optional)               <-- Common DTOs, constants, helper classes
│   ├── DTOs/
│   ├── Constants/
│   ├── Shared.csproj
│
├── ResumeBuilder.UI/                <-- Angular frontend
│   ├── src/
│   │   ├── app/
│   │   │   ├── auth/               <-- Login/Register components
│   │   │   ├── resume/             <-- Resume forms, lists, editor
│   │   │   └── services/           <-- API call services
│   │   ├── environments/
│   │   └── index.html
│   ├── angular.json
│   └── package.json
│
└── README.md
