from flask import Flask, render_template,redirect
import mlab
from mongoengine import *

mlab.connect()


class GirlType(Document):
    name = StringField()
    image = StringField()
    description = StringField()

girl_type = GirlType(name = "Gái tiểu thư",
                    image="https://via.placeholder.com/400x200",
                    description="Thường sang chảnh, thích nuông chiều, đòi hỏi thanh niên cần có chút 'vốn', thích đàn ông sạch sẽ, ăn mặc gọn gàng và có nhiều tài lẻ")
girl_type.save()

app = Flask(__name__)

girl_type = [
            {
                'name': "Gái tiểu thư",
                'image': "https://via.placeholder.com/400x200",
                'description': "Thường sang chảnh, thích nuông chiều, đòi hỏi thanh niên cần có chút 'vốn', thích đàn ông sạch sẽ, ăn mặc gọn gàng và có nhiều tài lẻ"
            },
            {
                'name': "Gái ngoan",
                'image': "https://via.placeholder.com/400x200",
                'description': "ăn mặc giản dị, không đua đòi, chịu khó, tính cách cẩn thận,chăm chỉ, chịu khó, hay đọc sách"
            },
            {
                'name': "Gái hư",
                'image': "https://via.placeholder.com/400x200",
                'description': "Hay đua đòi, ăn chơi, đi chơi qua đêm, bia, rượu,..."
            }
]
@app.route('/')
def index():
    return render_template('index.html', girl_types=GirlType.objects())


@app.route('/about')
def about():
    return render_template('about.html')

@app.route('/school')
def school():
    return redirect("http://techkids.vn")


app.run(port=8000, debug=True)
