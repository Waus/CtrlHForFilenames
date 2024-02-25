import os
import re

try:
    import eyed3
except ImportError as e:
    print("Error: " + str(e))
    print("eyed3 library is not installed. Please install it by running 'pip install eyed3'.")
    input("Press Enter to exit...")
    exit()

def set_mp3_tags():
    album_directory_name_regex = re.compile(r'^\d{4}\s-\s[\w*\s[(\.]+')
    path = os.getcwd()
    error_count = 0
    processed_files = 0
    
    for root, dirs, files in os.walk(path):
        for file in files:
            if file.endswith(".mp3"):
                try:
                    file_path = os.path.join(root, file)
                    file_path_splitted = file_path.split(os.sep)
                    len_path = len(file_path_splitted)

                    album_directory_name_test = file_path_splitted[-2]
                    if not album_directory_name_regex.match(album_directory_name_test):
                        len_path -= 1
                
                    file_name = os.path.splitext(file)[0]
                    is_album_split = "(Split)" in album_directory_name_test
                    artists = ['']
                    genres = ['']
                    track_name = ''
                    track_number = 0
                    album_year = 0
                    album_name = ''

                    if not is_album_split:
                        track_name = file_name[5:]
                        artists[0] = file_path_splitted[-3]
                    else:
                        index = file_name.find('-', file_name.find('-') + 1)
                        track_name = file_name[index + 2:]
                        artists[0] = file_name[5:index - 6]

                    track_number = int(file_name[:2])
                    album_directory_name = file_path_splitted[-2]
                    album_year = int(album_directory_name[:4])
                    album_name = album_directory_name[7:]
                    genres[0] = file_path_splitted[-4]

                    audio_file = eyed3.load(file_path)
                    if audio_file:
                        audio_file.tag.track_num = track_number
                        audio_file.tag.title = track_name
                        audio_file.tag.year = album_year
                        audio_file.tag.album = album_name
                        audio_file.tag.album_artist = artists[0]
                        audio_file.tag.artist = artists[0]
                        audio_file.tag.genre = genres[0]

                        audio_file.tag.save()
                    print(f"Successfully processed {file}")
                    processed_files += 1
                
                except Exception as e:
                    print(f"Error processing {file_path}: {e}")
                    error_count += 1

    print(f"Processing completed. Total files processed: {processed_files}. Errors: {error_count}.")

if __name__ == "__main__":
    set_mp3_tags()

