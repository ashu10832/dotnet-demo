pipeline {
    agent any

    stages {
        stage('Build'){
            steps{
                bat 'git log'
                bat 'dotnet build'
            }
        }
        stageTest('Test'){
            steps{
                bat 'dotnet test'
            }
        }
        stage('Publish'){
            steps{
                bat 'dotnet publish'
            }
        }
    }
}
