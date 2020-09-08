pipeline {
    agent any

    stages {
        stage('Build'){
            steps{
                bat 'git log'
                bat 'dotnet build'
                bat 'cd firstcoreproject'
            }
        }
        stage('Test'){
            steps{
                bat 'dotnet test'
            }
        }
        stage('Publish'){
            steps{
                bat 'dotnet publish'
            }
        }
        stage('Run'){
            steps{
                bat 'dotnet run'
            }
        }
    }
}
