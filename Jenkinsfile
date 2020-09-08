pipeline {
    agent any

    stages {
        stage('SCM') {
            steps {
                git 'https://github.com/ashu10832/dotnet-demo'
            }
        }
        stage('Build'){
            steps{
                bat 'git log'
                bat 'dotnet build'
            }
        }
        stage('Test'){
            steps{
                bat 'dotnet test'
            }
        }
    }
}
