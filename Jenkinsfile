pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/naoufelkhayati/tp3-ci-tests-v1.git'
            }
        }

        stage('Run .NET tests') {
            steps {
                dir('dotnet-app') {
                    sh 'dotnet test'
                }
            }
        }

        stage('Run Python tests') {
            steps {
                dir('python-app') {
                    sh 'python3 -m unittest'
                }
            }
        }
    }

    post {
        always {
            echo 'Pipeline finished !!!'
        }
    }
}
