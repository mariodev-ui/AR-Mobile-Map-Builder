# apps\regenquest-rules\scaffold.py

def scaffold_project(project_name):
    """
    Scaffolds a new project with basic files and directories.
    
    Args:
        project_name (str): The name of the project.
    """
    import os
    
    if not os.path.exists(project_name):
        os.makedirs(project_name)
    
    # Create basic files and directories
    os.makedirs(os.path.join(project_name, 'src'))
    os.makedirs(os.path.join(project_name, 'tests'))
    
    with open(os.path.join(project_name, 'README.md'), 'w') as f:
        f.write("# Project README\n")
    
    print(f"Project {project_name} scaffolded successfully")
