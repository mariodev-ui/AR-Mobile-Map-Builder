# apps\regenquest-rules\archive.py

def archive_files(source_dir, destination_dir):
    """
    Archives files from source directory to destination directory.
    
    Args:
        source_dir (str): The path to the source directory.
        destination_dir (str): The path to the destination directory.
    """
    import shutil
    import os
    
    if not os.path.exists(destination_dir):
        os.makedirs(destination_dir)
    
    for item in os.listdir(source_dir):
        s = os.path.join(source_dir, item)
        d = os.path.join(destination_dir, item)
        if os.path.isdir(s):
            shutil.copytree(s, d, dirs_exist_ok=True)
        else:
            shutil.copy2(s, d)
    print(f"Files archived from {source_dir} to {destination_dir}")
